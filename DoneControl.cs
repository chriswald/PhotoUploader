using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoUploader
{
	public partial class DoneControl : UserControl
	{
		public DoneControl()
		{
			InitializeComponent();
		}

		private void DoneControl_Resize(object sender, EventArgs e)
		{
			pictureBox.Top = (this.Height / 2) - (pictureBox.Height / 2);
			lblDone.Top = (this.Height / 2) - (lblDone.Height / 2);

			pictureBox.Left = (this.Width / 2) - ((pictureBox.Width + lblDone.Width) / 2);
			lblDone.Left = pictureBox.Right;
		}
	}
}
