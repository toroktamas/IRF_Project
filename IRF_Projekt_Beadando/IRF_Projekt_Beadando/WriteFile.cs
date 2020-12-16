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
    public partial class WriteFile : Form
    {
        public WriteFile()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Mentés
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            //Vissza
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void writeWithSaveFileDialog_Click(object sender, EventArgs e)
        {

        }
    }
}
