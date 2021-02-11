
namespace WindowsExplorer
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navigate = new GongSolutions.Shell.ShellTreeView();
            this.AllFiles = new GongSolutions.Shell.ShellView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.fileSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.naveBare = new GongSolutions.Shell.FileDialogToolbar();
            this.shellComboBox1 = new GongSolutions.Shell.ShellComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.navigate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.AllFiles);
            this.splitContainer1.Panel2.Controls.Add(this.naveBare);
            this.splitContainer1.Panel2.Controls.Add(this.shellComboBox1);
            this.splitContainer1.Size = new System.Drawing.Size(772, 566);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 0;
            // 
            // navigate
            // 
            this.navigate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigate.Location = new System.Drawing.Point(0, 0);
            this.navigate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigate.Name = "navigate";
            this.navigate.ShellView = this.AllFiles;
            this.navigate.Size = new System.Drawing.Size(256, 566);
            this.navigate.TabIndex = 0;
            // 
            // AllFiles
            // 
            this.AllFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllFiles.Location = new System.Drawing.Point(0, 39);
            this.AllFiles.Name = "AllFiles";
            this.AllFiles.Size = new System.Drawing.Size(512, 527);
            this.AllFiles.StatusBar = null;
            this.AllFiles.TabIndex = 4;
            this.AllFiles.Text = "shellView1";
            this.AllFiles.SelectionChanged += new System.EventHandler(this.AllFiles_SelectionChanged);
            this.AllFiles.DoubleClick += new System.EventHandler(this.AllFiles_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileSize});
            this.statusStrip1.Location = new System.Drawing.Point(0, 544);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(512, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // fileSize
            // 
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(0, 16);
            // 
            // naveBare
            // 
            this.naveBare.AutoSize = true;
            this.naveBare.Dock = System.Windows.Forms.DockStyle.Top;
            this.naveBare.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.naveBare.Location = new System.Drawing.Point(0, 0);
            this.naveBare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.naveBare.Name = "naveBare";
            this.naveBare.ShellView = this.AllFiles;
            this.naveBare.Size = new System.Drawing.Size(512, 39);
            this.naveBare.TabIndex = 3;
            // 
            // shellComboBox1
            // 
            this.shellComboBox1.Location = new System.Drawing.Point(95, 50);
            this.shellComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shellComboBox1.Name = "shellComboBox1";
            this.shellComboBox1.Size = new System.Drawing.Size(8, 7);
            this.shellComboBox1.TabIndex = 1;
            this.shellComboBox1.Text = "shellComboBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 566);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private GongSolutions.Shell.ShellComboBox shellComboBox1;
        private GongSolutions.Shell.FileDialogToolbar naveBare;
        private GongSolutions.Shell.ShellView AllFiles;
        private GongSolutions.Shell.ShellTreeView navigate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel fileSize;
    }
}

