using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WindowsExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AllFiles_DoubleClick(object sender, EventArgs e)
        {
            string parentPath="";
            //   string all=   root.SelectedFolder.ToString().Replace("shell:///", "");
            if (naveBare.SelectedFolder.ToString().Contains("file:///") )
            {
                 parentPath = naveBare.SelectedFolder.ToString().Replace("file:///", "");
            }
            if (naveBare.SelectedFolder.ToString().Contains("shell:///"))
            {
                parentPath = naveBare.SelectedFolder.ToString().Replace("shell:///", "");
                if (parentPath.Contains("Desktop"))
                {
                    parentPath = @"C:/Users/Administrator/Desktop";
                }
                 
            }

            string path = parentPath + @"/"  +AllFiles.SelectedItems[0].DisplayName.ToString() ;
 
            if (File.Exists(path))
            {
                 Process.Start(path);
              //  MessageBox.Show("message", "message", MessageBoxButtons.OK);
            }
        }

   

        private void AllFiles_SelectionChanged(object sender, EventArgs e)
        {

            string parentPath = "";
            //   string all=   root.SelectedFolder.ToString().Replace("shell:///", "");
            if (naveBare.SelectedFolder.ToString().Contains("file:///"))
            {
                parentPath = naveBare.SelectedFolder.ToString().Replace("file:///", "");
            }
            if (naveBare.SelectedFolder.ToString().Contains("shell:///"))
            {
                parentPath = naveBare.SelectedFolder.ToString().Replace("shell:///", "");
                if (parentPath.Contains("Desktop"))
                {
                    parentPath = @"C:/Users/Administrator/Desktop";
                }

            }
            
            try
            {
                string path = parentPath + @"/" + AllFiles.SelectedItems[0].DisplayName.ToString();

                if (File.Exists(path))
                {

                    Int64 Size = new FileInfo(path).Length / 2048;
                    fileSize.Text = "File Size :" + Size.ToString() + " MB";
                }
            }
            catch (Exception)
            {

            }


            
           
        }
    }
}
