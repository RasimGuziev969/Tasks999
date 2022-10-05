using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        private string folderpath = "";
        private string[] files;
        private Encoding enc = Encoding.UTF8;
        public Form1()
        {
            InitializeComponent();
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowNewFolderButton = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                folderpath = folderBrowserDialog1.SelectedPath;
                label1.Text = folderpath;
            }

            if (folderpath != "")
            {
                if (Directory.Exists(folderpath))
                {
                    files = Directory.GetFiles(folderpath, "*.txt");
                    foreach (string file in files)
                    {
                        listBox1.Items.Add(Path.GetFileName(file));
                    }
                    listBox1.SelectedIndex = 0;
                }
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReadTxt();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                enc = Encoding.UTF8;
                ReadTxt();
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                enc = Encoding.GetEncoding(1251);
                ReadTxt();
            }
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                enc = Encoding.GetEncoding(866);
                ReadTxt();
            }
        }

        private void ReadTxt()
        {
            if (listBox1.Items != null)
            {
                string fls = folderpath + "\\" + (string)listBox1.SelectedItem;
                using (StreamReader sr = new StreamReader(fls, enc))
                {
                    textBox1.Text = sr.ReadToEnd();
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
