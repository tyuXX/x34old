using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;


namespace x34
{
    public partial class x34Editor : Form
    {
        public string dir = "C:";
        internal string[] info;
        internal bool tooltips = true;
        internal string openfile = "";
        public x34Editor()
        {
            InitializeComponent();
        }

        private void x34Editor_Load(object sender, EventArgs e)
        {
            try
            {
                info = Generate.options( dir, false );
                workspacesToolStripMenuItem.Text += info[0];
                testbasesToolStripMenuItem.Text += info[1];
                testsToolStripMenuItem.Text += info[2];
                loadfolder( dir );
            }
            catch (Exception)
            {
                Close();
            }
        }
        #region Treeview
        public void loadfolder(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            fileload(Dir, tds);
            childloadfolder(Dir, tds);
        }

        private void childloadfolder(string dir, TreeNode td)
        {

            string[] subdirectoryEntries = Directory.GetDirectories(dir);

            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                fileload(subdirectory, tds);
                childloadfolder(subdirectory, tds);
            }
        }

        private void fileload(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
            }
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {

            if (tooltips)
            {
                TreeNode theNode = treeView1.GetNodeAt( e.X, e.Y );
                if (theNode != null && theNode.Tag != null)
                {
                    if (theNode.Tag.ToString() != toolTip1.GetToolTip( treeView1 ))
                    {
                        toolTip1.SetToolTip( treeView1, theNode.Tag.ToString() );
                    }

                }
                else
                {
                    toolTip1.SetToolTip( treeView1, "" );
                }
            }
            else
            {
                toolTip1.SetToolTip(treeView1,"");
            }
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (File.Exists( e.Node.Tag.ToString() ))
            {
                label1.Text = "File:" + e.Node.Tag.ToString();
                openfile = e.Node.Tag.ToString();
                richTextBox1.Text = File.ReadAllText(e.Node.Tag.ToString());
            }
        }
        #endregion Treeview

        private void toolTipsONToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (tooltips)
            {
                tooltips = false;
                toolTipsONToolStripMenuItem.Text = "Tool Tips OFF";
            }
            else
            {
                tooltips = true;
                toolTipsONToolStripMenuItem.Text = "Tool Tips ON";
            }
        }

        private void saveFileToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if (!string.IsNullOrEmpty( openfile ))
            {
                File.WriteAllText( openfile, richTextBox1.Text );
                label1.Text = "File:" + openfile;
            }
        }

        private void richTextBox1_TextChanged( object sender, EventArgs e )
        {
            if (!string.IsNullOrEmpty( openfile ))
            {
                label1.Text = "File:*" + openfile;
            }
        }

        private void regenerateX34ToolStripMenuItem_Click( object sender, EventArgs e )
        {
            Generate.x34( dir, Convert.ToInt32(info[0]), Convert.ToInt32( info[1]), Convert.ToInt32( info[2]),true,true);
            treeView1 = new TreeView();
            loadfolder( dir );
        }
    }
}
