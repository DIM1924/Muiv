using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WWW
{
    public partial class Telega : Form
    {
        private Engine _engine;
        public Telega(Engine engine)
        {
            _engine = engine;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            richTextBox2.Text = richTextBox2.Text + "\n" + richTextBox1.Text;
            _engine.SendMesage(richTextBox1.Text);


            richTextBox1.Text = "";



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
