namespace PhotoUploader
{
	partial class DoneControl
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
			this.lblDone = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// lblDone
			// 
			this.lblDone.AutoSize = true;
			this.lblDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDone.Location = new System.Drawing.Point(57, 3);
			this.lblDone.Name = "lblDone";
			this.lblDone.Size = new System.Drawing.Size(66, 24);
			this.lblDone.TabIndex = 0;
			this.lblDone.Text = "Done!";
			// 
			// pictureBox
			// 
			this.pictureBox.Image = global::PhotoUploader.Properties.Resources.check_mark_1_240;
			this.pictureBox.Location = new System.Drawing.Point(3, 3);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(48, 48);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			// 
			// DoneControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.lblDone);
			this.Name = "DoneControl";
			this.Size = new System.Drawing.Size(141, 63);
			this.Resize += new System.EventHandler(this.DoneControl_Resize);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDone;
		private System.Windows.Forms.PictureBox pictureBox;
	}
}
