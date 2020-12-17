using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Projekt_Beadando
{
    public partial class WriteFile : Form
    {
        public List<FlatData> FlatData { get; set; }

        public string FileName { get; set; }

        public WriteFile(List<FlatData> flatData)
        {
            InitializeComponent();
            FlatData = flatData;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Mentés
            using (StreamWriter sw = new StreamWriter(FileName))
            {
                foreach (var item in FlatData)
                {
                    sw.WriteLine(
                        String.Format(
                            "{0};{1};{2};{3};{4};{5};{6};{7}\n",
                            item.Kod,
                            item.Elado,
                            item.Oldal,
                            item.Kerulet,
                            (item.Lift == true) ? "Van" : "Nincs" ,
                            item.SzobakSzama,
                            item.Alapterulet,
                            item.Ar
                            ));
                }
            }
            this.Close();
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
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = saveFileDialog1.FileName;
            }
            openFileDialogPathText.Text = FileName;
        }
    }
}
