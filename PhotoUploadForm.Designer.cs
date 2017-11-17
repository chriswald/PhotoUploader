namespace PhotoUploader
{
	partial class PhotoUploadForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.photoUploadControl = new PhotoUploader.PhotoUploadControl();
			this.doneControl = new PhotoUploader.DoneControl();
			this.SuspendLayout();
			// 
			// photoUploadControl
			// 
			this.photoUploadControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.photoUploadControl.Location = new System.Drawing.Point(0, 0);
			this.photoUploadControl.Name = "photoUploadControl";
			this.photoUploadControl.Size = new System.Drawing.Size(565, 244);
			this.photoUploadControl.TabIndex = 0;
			// 
			// doneControl
			// 
			this.doneControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.doneControl.Location = new System.Drawing.Point(0, 0);
			this.doneControl.Name = "doneControl";
			this.doneControl.Size = new System.Drawing.Size(565, 244);
			this.doneControl.TabIndex = 1;
			// 
			// PhotoUploadForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 244);
			this.Controls.Add(this.photoUploadControl);
			this.Controls.Add(this.doneControl);
			this.MaximizeBox = false;
			this.Name = "PhotoUploadForm";
			this.Text = "Photo Uploader";
			this.ResumeLayout(false);

		}

		#endregion
		private PhotoUploadControl photoUploadControl;
		private DoneControl doneControl;
	}
}

