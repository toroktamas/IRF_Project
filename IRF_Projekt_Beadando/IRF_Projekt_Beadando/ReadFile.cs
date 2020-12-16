using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt_Beadando
{
    public partial class ReadFile : Form
    {
        public string FilePath { get; set; }

        public ReadFile()
        {
            InitializeComponent();
        }

        private void openForm1_Click(object sender, EventArgs e)
        {
            if (FilePath!= string.Empty)
            {
                Form1 form1 = new Form1(FilePath);
                form1.ShowDialog();
                this.Close();
            }
            else
            {
                ErrorMesseges.Text = "Kérem válaszon ki fájlt";
            }

        }

        private void readWhidOpenFileDialog_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FilePath = openFileDialog.FileName;
                }
            }
            openFileDialogPathText.Text = FilePath;
        }
    }
}
