﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoUploader
{
	public partial class PhotoUploadForm : Form
	{
		public PhotoUploadForm()
		{
			InitializeComponent();

			photoUploadControl.UploadDone += () =>
			{
				photoUploadControl.Visible = false;
				doneControl.Visible = true;
			};
		}
	}
}
