using System;
using System.Windows.Forms;

namespace x34
{
    public partial class x34Generator : Form
    {
        public x34Generator( )
        {
            InitializeComponent ( );
        }

        private void x34Generator_Load( object sender , EventArgs e )
        {

        }

        private void folderbrowse_HelpRequest( object sender , EventArgs e )
        {

        }

        private void button1_Click( object sender , EventArgs e )
        {
            try
            {
                Generate.x34 ( textBox1.Text , Convert.ToInt32 ( textBox2.Text ) , Convert.ToInt32 ( textBox3.Text ) , Convert.ToInt32 ( textBox4.Text ) );
                if ((!string.IsNullOrEmpty ( textBox5.Text )) && (!string.IsNullOrEmpty ( textBox6.Text )))
                {
                    Generate.newuser ( textBox1.Text , textBox6.Text , textBox5.Text );
                }
                MessageBox.Show ( "Sucsess" );
            }
            catch (Exception)
            {
                MessageBox.Show ( "Please Check the textboxes for a unuseable char." );
            }
        }

        private void button2_Click( object sender , EventArgs e )
        {
            if (folderbrowse.ShowDialog ( ) == DialogResult.OK)
            {
                textBox1.Text = folderbrowse.SelectedPath;
            }
        }
    }
}
