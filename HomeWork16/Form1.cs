using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            exitToolStripMenuItem.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgR = openFileDialog1.ShowDialog();
            if (dlgR==DialogResult.Cancel);
                return;
            this.Text = openFileDialog1.FileName;
            richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            toolStripStatusLabel1.Text = "Open";
            toolStripStatusLabel2.Text = openFileDialog1.FileName;
            

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            saveAsToolStripMenuItem.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgR = saveFileDialog1.ShowDialog();
            if (dlgR == DialogResult.Cancel) ;
            return;
            this.Text = saveFileDialog1.FileName;
            richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }
    }
}
