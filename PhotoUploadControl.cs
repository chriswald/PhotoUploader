using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using System.Net;

namespace PhotoUploader
{
	public partial class PhotoUploadControl : UserControl
	{
		private const int ControlBorder = 3;
		private const int ControlSpacing = 6;

		private readonly string[] Filters = new string[] { "jpg", "jpeg", "png", "wmv", "mov", "mp4" };

		private List<string> _photoPaths = new List<string>();

		public delegate void UploadDoneHandler();
		public delegate void UpdateProgressCallback();

		public event UploadDoneHandler UploadDone;
		
		public PhotoUploadControl()
		{
			InitializeComponent();
		}

		private void PhotoUploadControl_Resize(object sender, EventArgs e)
		{
			// Expand the folder controls
			btnBrowse.Left = this.Width - ControlBorder - btnBrowse.Width;
			txtPath.Width = btnBrowse.Left - ControlSpacing - ControlBorder;

			// Recenter the upload button
			btnUpload.Left = (this.Width / 2) - (btnUpload.Width / 2);

			// Expand the progress bar
			progressBar.Width = this.Width - (ControlBorder * 2);
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				txtPath.Text = folderBrowserDialog.SelectedPath;

				if (_photoPaths.Count == 0)
				{
					MessageBox.Show("The selected folder doesn't contain any photos that can be uploaded.", "No photos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void txtPath_TextChanged(object sender, EventArgs e)
		{
			btnUpload.Enabled = false;

			if (!string.IsNullOrEmpty(txtPath.Text))
			{
				FindPhotos(txtPath.Text);

				if (_photoPaths.Count > 0)
				{
					btnUpload.Enabled = true;
				}
			}
		}
		
		private void btnUpload_Click(object sender, EventArgs e)
		{
			progressBar.Maximum = _photoPaths.Count + 1;
			progressBar.Step = 1;

			btnBrowse.Enabled = false;
			txtPath.Enabled = false;
			btnUpload.Enabled = false;

			Task.Run(() => { UploadPhotos(); });
		}

		private void FindPhotos(string path)
		{
			_photoPaths.Clear();

			if (!Directory.Exists(path)) { return; }

			foreach (string filter in Filters)
			{
				_photoPaths.AddRange(Directory.GetFiles(path, $"*.{filter}", SearchOption.AllDirectories));
			}
		}

		private void UploadPhotos()
		{
			UpdateProgressCallback updateProgress = progressBar.PerformStep;

			foreach (string path in _photoPaths)
			{
				UploadPhoto(path);
				this.Invoke(updateProgress);
			}

			ZipPhotos();

			OnUploadDone();
		}

		private void UploadPhoto(string path)
		{
			HttpClient client = new HttpClient();
			MultipartFormDataContent content = new MultipartFormDataContent();
			content.Add(new StreamContent(File.Open(path, FileMode.Open)), "file", path);
			var result = client.PostAsync("https://content.chriswald.com/photo/upload", content).Result;
		}

		private void ZipPhotos()
		{
			HttpClient client = new HttpClient();
			var result = client.PostAsync("https://content.chriswald.com/photo/zipphotos", null).Result;
		}

		private void OnUploadDone()
		{
			UploadDone?.Invoke();
		}
	}
}
