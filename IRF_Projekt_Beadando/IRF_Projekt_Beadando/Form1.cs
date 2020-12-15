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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void openWriteFileButton_Click(object sender, EventArgs e)
        {
            WriteFile file = new WriteFile();
            file.ShowDialog();
            this.Close();
        }

        private void importDataButton_Click(object sender, EventArgs e)
        {
            ReadFile file = new ReadFile();
            file.ShowDialog();
            this.Close();
        }
    }
}
