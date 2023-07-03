using System;
using System.IO;
using System.Windows.Forms;

namespace x34
{
    public partial class x34 : Form
    {
        public x34( )
        {
            InitializeComponent ( );
        }

        private void x34_Load( object sender , EventArgs e )
        {
            if (File.Exists ( @".\recent" ))
            {
                foreach (string i in File.ReadAllLines ( @".\recent" ))
                {
                    comboBox1.Items.Add ( i );
                }
            }
        }

        private void button1_Click( object sender , EventArgs e )
        {
            x34Generator x34Generator = new x34Generator ( );
            x34Generator.Show ( );
        }

        private void button3_Click( object sender , EventArgs e )
        {
            if (folderbrowse.ShowDialog ( ) == DialogResult.OK)
            {
                comboBox1.Text = folderbrowse.SelectedPath;
            }
        }

        private void button2_Click( object sender , EventArgs e )
        {
            if (!string.IsNullOrEmpty ( comboBox1.Text ))
            {
                bool found = false;
                if (File.Exists ( @".\recent" ))
                {
                    foreach (string i in File.ReadAllLines ( @".\recent" ))
                    {
                        if (comboBox1.Text == i)
                        {
                            found = true;
                            break;
                        }
                    }
                }
                if (!found)
                {
                    File.AppendAllText ( @".\recent" , comboBox1.Text + "\n" );
                    if (File.Exists ( @".\recent" ))
                    {
                        comboBox1.Items.Clear ( );
                        foreach (string i in File.ReadAllLines ( @".\recent" ))
                        {
                            comboBox1.Items.Add ( i );
                        }
                    }
                }
                Login login = new Login ( );
                login.dir = comboBox1.Text;
                login.Show ( );
            }
        }
    }
}
