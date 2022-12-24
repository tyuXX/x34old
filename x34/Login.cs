using System;
using System.IO;
using System.Windows.Forms;

namespace x34
{
    public partial class Login : Form
    {
        public string dir = "C:";
        internal string[ ] info;
        public Login( )
        {
            InitializeComponent ( );
        }

        private void button1_Click( object sender , EventArgs e )
        {
            if (File.Exists ( dir + @"\x34-Core\users\" + textBox1.Text ))
            {
                string[ ] str = File.ReadAllLines ( dir + @"\x34-Core\users\" + textBox1.Text );
                if (str[ 0 ] == maskedTextBox1.Text)
                {
                    x34Editor x34Editor = new x34Editor ( );
                    x34Editor.dir = dir;
                    x34Editor.username = textBox1.Text;
                    x34Editor.userrole = str[ 2 ];
                    x34Editor.Show ( );
                    this.Close ( );
                }
                else
                {
                    textBox1.Clear ( );
                    maskedTextBox1.Clear ( );
                }
            }
            else
            {
                textBox1.Clear ( );
                maskedTextBox1.Clear ( );
            }
        }

        private void Login_Load( object sender , EventArgs e )
        {
            try
            {
                info = Generate.options ( dir , false );
            }
            catch (Exception)
            {
                this.Close ( );
            }
        }
    }
}
