
namespace FindMyMusic
{
    partial class FindMyMusic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bStop = new System.Windows.Forms.Button();
            this.bCopy = new System.Windows.Forms.Button();
            this.bPlayList = new System.Windows.Forms.Button();
            this.bFolderToCopy = new System.Windows.Forms.Button();
            this.labelPlaylist = new System.Windows.Forms.Label();
            this.labelDestFold = new System.Windows.Forms.Label();
            this.labelPlaylistPath = new System.Windows.Forms.Label();
            this.labelDestFolderPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 153);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(700, 25);
            this.progressBar.TabIndex = 0;
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(194, 190);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(170, 30);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bCopy
            // 
            this.bCopy.Location = new System.Drawing.Point(370, 190);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(170, 30);
            this.bCopy.TabIndex = 1;
            this.bCopy.Text = "Copy";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click);
            // 
            // bPlayList
            // 
            this.bPlayList.Location = new System.Drawing.Point(194, 110);
            this.bPlayList.Name = "bPlayList";
            this.bPlayList.Size = new System.Drawing.Size(170, 30);
            this.bPlayList.TabIndex = 1;
            this.bPlayList.Text = "Playlist";
            this.bPlayList.UseVisualStyleBackColor = true;
            this.bPlayList.Click += new System.EventHandler(this.bPlayList_Click);
            // 
            // bFolderToCopy
            // 
            this.bFolderToCopy.Location = new System.Drawing.Point(370, 110);
            this.bFolderToCopy.Name = "bFolderToCopy";
            this.bFolderToCopy.Size = new System.Drawing.Size(170, 30);
            this.bFolderToCopy.TabIndex = 1;
            this.bFolderToCopy.Text = "Folder to copy";
            this.bFolderToCopy.UseVisualStyleBackColor = true;
            this.bFolderToCopy.Click += new System.EventHandler(this.bFolderToCopy_Click);
            // 
            // labelPlaylist
            // 
            this.labelPlaylist.AutoSize = true;
            this.labelPlaylist.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlaylist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlaylist.Location = new System.Drawing.Point(87, 18);
            this.labelPlaylist.Name = "labelPlaylist";
            this.labelPlaylist.Size = new System.Drawing.Size(68, 21);
            this.labelPlaylist.TabIndex = 2;
            this.labelPlaylist.Text = "Playlist: ";
            this.labelPlaylist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDestFold
            // 
            this.labelDestFold.AutoSize = true;
            this.labelDestFold.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDestFold.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDestFold.Location = new System.Drawing.Point(16, 40);
            this.labelDestFold.Name = "labelDestFold";
            this.labelDestFold.Size = new System.Drawing.Size(135, 21);
            this.labelDestFold.TabIndex = 2;
            this.labelDestFold.Text = "Destination folder:";
            this.labelDestFold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlaylistPath
            // 
            this.labelPlaylistPath.AutoSize = true;
            this.labelPlaylistPath.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlaylistPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlaylistPath.Location = new System.Drawing.Point(157, 18);
            this.labelPlaylistPath.Name = "labelPlaylistPath";
            this.labelPlaylistPath.Size = new System.Drawing.Size(34, 21);
            this.labelPlaylistPath.TabIndex = 2;
            this.labelPlaylistPath.Text = "___";
            this.labelPlaylistPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDestFolderPath
            // 
            this.labelDestFolderPath.AutoSize = true;
            this.labelDestFolderPath.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDestFolderPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDestFolderPath.Location = new System.Drawing.Point(157, 39);
            this.labelDestFolderPath.Name = "labelDestFolderPath";
            this.labelDestFolderPath.Size = new System.Drawing.Size(34, 21);
            this.labelDestFolderPath.TabIndex = 2;
            this.labelDestFolderPath.Text = "___";
            this.labelDestFolderPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FindMyMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.labelDestFolderPath);
            this.Controls.Add(this.labelPlaylistPath);
            this.Controls.Add(this.labelDestFold);
            this.Controls.Add(this.labelPlaylist);
            this.Controls.Add(this.bFolderToCopy);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.bPlayList);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindMyMusic";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Button bPlayList;
        private System.Windows.Forms.Button bFolderToCopy;
        private System.Windows.Forms.Label labelPlaylist;
        private System.Windows.Forms.Label labelDestFold;
        private System.Windows.Forms.Label labelPlaylistPath;
        private System.Windows.Forms.Label labelDestFolderPath;
    }
}

