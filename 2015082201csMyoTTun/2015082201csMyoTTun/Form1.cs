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

namespace _2015082201csMyoTTun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Set filter options and filter index.
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                // Open the selected file to read.
                if (File.Exists (openFileDialog1 .FileName))
                {
                    StreamReader sr = new StreamReader(openFileDialog1.FileName);
                    String sText = sr.ReadToEnd().ToString ();
                    txtEdit.Text = sText;
                    sr.Close();
                }
                

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1 .Filter= "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                // Open the selected file to read.
                if (!File.Exists(saveFileDialog1.FileName))
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(txtEdit.Text.ToString());
                    sw.Close();
                }


            }
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string  item = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            
            //MessageBox.Show(item);
            switch (this.comboBox1.GetItemText(this.comboBox1.SelectedItem))
            {
                case "A": break;
                case "B": break;
                case "C": break;
                case "D": break;
            }

           string results = checkedListBox1.GetItemText(checkedListBox1.SelectedItems);
           MessageBox.Show(results);

        }
    }
}
