namespace PhotoUploader
{
	partial class PhotoUploadControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblStepOne = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.lblStepTwo = new System.Windows.Forms.Label();
			this.btnUpload = new System.Windows.Forms.Button();
			this.lblStepThree = new System.Windows.Forms.Label();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// lblStepOne
			// 
			this.lblStepOne.AutoSize = true;
			this.lblStepOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStepOne.Location = new System.Drawing.Point(3, 0);
			this.lblStepOne.Name = "lblStepOne";
			this.lblStepOne.Size = new System.Drawing.Size(376, 24);
			this.lblStepOne.TabIndex = 0;
			this.lblStepOne.Text = "1. Choose the folder with your photos...";
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(3, 27);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(438, 20);
			this.txtPath.TabIndex = 1;
			this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(447, 25);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "&Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// lblStepTwo
			// 
			this.lblStepTwo.AutoSize = true;
			this.lblStepTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStepTwo.Location = new System.Drawing.Point(3, 74);
			this.lblStepTwo.Name = "lblStepTwo";
			this.lblStepTwo.Size = new System.Drawing.Size(168, 24);
			this.lblStepTwo.TabIndex = 3;
			this.lblStepTwo.Text = "2. Click Upload...";
			// 
			// btnUpload
			// 
			this.btnUpload.Enabled = false;
			this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpload.Location = new System.Drawing.Point(212, 101);
			this.btnUpload.Name = "btnUpload";
			this.btnUpload.Size = new System.Drawing.Size(141, 39);
			this.btnUpload.TabIndex = 4;
			this.btnUpload.Text = "&Upload";
			this.btnUpload.UseVisualStyleBackColor = true;
			this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
			// 
			// lblStepThree
			// 
			this.lblStepThree.AutoSize = true;
			this.lblStepThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStepThree.Location = new System.Drawing.Point(3, 167);
			this.lblStepThree.Name = "lblStepThree";
			this.lblStepThree.Size = new System.Drawing.Size(91, 24);
			this.lblStepThree.TabIndex = 5;
			this.lblStepThree.Text = "3. Wait...";
			// 
			// progressBar
			// 
			this.progressBar.Location = new System.Drawing.Point(3, 194);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(519, 23);
			this.progressBar.TabIndex = 6;
			// 
			// PhotoUploadControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.progressBar);
			this.Controls.Add(this.lblStepThree);
			this.Controls.Add(this.btnUpload);
			this.Controls.Add(this.lblStepTwo);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.lblStepOne);
			this.Name = "PhotoUploadControl";
			this.Size = new System.Drawing.Size(525, 220);
			this.Resize += new System.EventHandler(this.PhotoUploadControl_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblStepOne;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label lblStepTwo;
		private System.Windows.Forms.Button btnUpload;
		private System.Windows.Forms.Label lblStepThree;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
	}
}
