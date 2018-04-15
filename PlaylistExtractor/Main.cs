using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaylistExtractor
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ofdSelectPlaylist.ShowDialog() == DialogResult.OK && File.Exists(ofdSelectPlaylist.FileName))
			{
				txtPlaylistPath.Text = ofdSelectPlaylist.FileName;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (fbdOutputFolder.ShowDialog() == DialogResult.OK)
			{
				txtOutputFolderPath.Text = fbdOutputFolder.SelectedPath;
			}
		}

		private void ExtractPlaylist()
		{
			Cursor.Current = Cursors.WaitCursor;
			try
			{
				if (!File.Exists(txtPlaylistPath.Text) && !Directory.Exists(txtOutputFolderPath.Text))
				{
					MessageBox.Show("Either the source or destination path is incorrect or does not exist.");
					return;
				}

				var dataset = new DataSet();
				dataset.ReadXml(txtPlaylistPath.Text);

				var songsTable = dataset.Tables["media"];

				foreach (DataRow row in songsTable.Rows)
				{
					var absolutePathOfSong = Path.Combine(txtPlaylistPath.Text, @"..\" + row["src"].ToString());
					var songPath = Path.GetFullPath((new Uri(absolutePathOfSong)).LocalPath);
					if(File.Exists(songPath))
						File.Copy(songPath, txtOutputFolderPath.Text + @"\" + Path.GetFileName(songPath));
				}
			}
			finally
			{
				Cursor.Current = Cursors.Default;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			ExtractPlaylist();
			MessageBox.Show("Complete!");
		}
	}
}
