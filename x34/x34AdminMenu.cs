using System;
using System.IO;
using System.Windows.Forms;

namespace x34
{
    public partial class x34AdminMenu : Form
    {
        public string dir = "C:";
        public string username = "user";
        public string userrole = "Default";
        internal string[ ] user = new string[ 3 ];
        internal string openfile = "";
        public x34AdminMenu( )
        {
            InitializeComponent ( );
        }

        private void x34AdminMenu_Load( object sender , EventArgs e )
        {
            loadfolder ( dir + @"\x34-Core\users" );
        }
        #region Treeview
        public void loadfolder( string Dir )
        {
            DirectoryInfo di = new DirectoryInfo ( Dir );
            TreeNode tds = treeView1.Nodes.Add ( di.Name );
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            fileload ( Dir , tds );
            childloadfolder ( Dir , tds );
        }

        private void childloadfolder( string dir , TreeNode td )
        {

            string[ ] subdirectoryEntries = Directory.GetDirectories ( dir );

            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo ( subdirectory );
                TreeNode tds = td.Nodes.Add ( di.Name );
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                fileload ( subdirectory , tds );
                childloadfolder ( subdirectory , tds );
            }
        }

        private void fileload( string dir , TreeNode td )
        {
            string[ ] Files = Directory.GetFiles ( dir , "*.*" );
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo ( file );
                TreeNode tds = td.Nodes.Add ( fi.Name );
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
            }
        }
        #endregion Treeview

        private void treeView1_NodeMouseDoubleClick( object sender , TreeNodeMouseClickEventArgs e )
        {
            if (File.Exists ( e.Node.Tag.ToString ( ) ))
            {
                user = File.ReadAllLines ( e.Node.Tag.ToString ( ) );
                textBox1.Text = new FileInfo ( e.Node.Tag.ToString ( ) ).Name;
                textBox2.Text = user[ 0 ];
                textBox3.Text = user[ 1 ];
                comboBox1.Text = user[ 2 ];
                openfile = e.Node.Tag.ToString ( );
            }
        }

        private void saveToolStripMenuItem_Click( object sender , EventArgs e )
        {
            if (!(string.IsNullOrEmpty ( textBox1.Text ) && string.IsNullOrEmpty ( textBox2.Text ) && string.IsNullOrEmpty ( textBox3.Text ) && string.IsNullOrEmpty ( comboBox1.Text )))
            {
                if (!File.Exists ( dir + @"\x34-Core\users\" + textBox1.Text ))
                {
                    File.WriteAllLines ( dir + @"\x34-Core\users\" + textBox1.Text , new string[ ] { textBox2.Text , textBox3.Text , comboBox1.Text } );
                    textBox1.Clear ( );
                    textBox2.Clear ( );
                    textBox3.Clear ( );
                    comboBox1.Text = "";
                    openfile = "";
                }
                else
                {
                    File.WriteAllLines ( dir + @"\x34-Core\users\" + textBox1.Text , new string[ ] { textBox2.Text , textBox3.Text , comboBox1.Text } );
                }
                treeView1.Nodes.Clear ( );
                loadfolder ( dir + @"\x34-Core\users" );
            }
        }

        private void button1_Click( object sender , EventArgs e )
        {
            textBox3.Text = Guid.NewGuid ( ).ToString ( );
        }
    }
}
