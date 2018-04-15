namespace PlaylistExtractor
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.button1 = new System.Windows.Forms.Button();
			this.ofdSelectPlaylist = new System.Windows.Forms.OpenFileDialog();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.txtPlaylistPath = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.txtOutputFolderPath = new System.Windows.Forms.TextBox();
			this.fbdOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(27, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 30);
			this.button1.TabIndex = 0;
			this.button1.Text = "Select Playlist";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(161, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(253, 20);
			this.textBox1.TabIndex = 1;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(80, 116);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(246, 60);
			this.button3.TabIndex = 4;
			this.button3.Text = "Extract Playlist";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(27, 69);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(128, 30);
			this.button4.TabIndex = 0;
			this.button4.Text = "Select Playlist";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtPlaylistPath
			// 
			this.txtPlaylistPath.Location = new System.Drawing.Point(161, 75);
			this.txtPlaylistPath.Name = "txtPlaylistPath";
			this.txtPlaylistPath.Size = new System.Drawing.Size(253, 20);
			this.txtPlaylistPath.TabIndex = 1;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(27, 33);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(128, 30);
			this.button5.TabIndex = 2;
			this.button5.Text = "Select Output Folder";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// txtOutputFolderPath
			// 
			this.txtOutputFolderPath.Location = new System.Drawing.Point(161, 39);
			this.txtOutputFolderPath.Name = "txtOutputFolderPath";
			this.txtOutputFolderPath.Size = new System.Drawing.Size(253, 20);
			this.txtOutputFolderPath.TabIndex = 3;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(443, 194);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.txtOutputFolderPath);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.txtPlaylistPath);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Windows Media Player Playlist Extractor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog ofdSelectPlaylist;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox txtPlaylistPath;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox txtOutputFolderPath;
		private System.Windows.Forms.FolderBrowserDialog fbdOutputFolder;
	}
}

