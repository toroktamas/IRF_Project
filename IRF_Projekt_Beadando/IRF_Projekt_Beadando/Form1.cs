using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace IRF_Projekt_Beadando
{
    public partial class Form1 : Form
    {
        enum lift { Van, Nincs  }
        public List<FlatData> FlatData { get; set; }
            = new List<FlatData>();

        public Form1(string filePath)
        {
            InitializeComponent();
            FileReading(filePath);
            PullElementValue();
        }

        public Form1()
        {
            InitializeComponent();
            PullElementValue();
        }

        public void PullElementValue() 
        {
            liftComboBox1.DisplayMember = "Text";
            liftComboBox1.ValueMember = "Value";

            liftComboBox1.DataSource = new[] {
                new { Text = lift.Van.ToString(), Value = "true" },
                new { Text = lift.Nincs.ToString(), Value = "false" }
            };

            keruletListBox1.DataSource = FlatData
                .GroupBy(k => k.Kerulet)
                .OrderBy(k => k.Key)
                .Select(k => k.Key)
                .ToList();

            szobaSzamListBox2.DataSource = FlatData
                .GroupBy(m => m.SzobakSzama)
                .OrderBy(k => k.Key)
                .Select(k => k.Key)
                .ToList();

            productTextBox1.Text = FlatData.Count.ToString();
        }

        public void FileReading(string fileName)
        {
            try
            {
                XElement file = XElement.Load(fileName);
                foreach (var item in file.Descendants("record"))
                {
                    var data = new FlatData()
                    {
                        Kod = item.Elements("Kod").FirstOrDefault().Value.ToString(),
                        Elado = item.Elements("Elado").FirstOrDefault().Value.ToString(),
                        Oldal = item.Elements("Oldal").FirstOrDefault().Value.ToString(),
                        Kerulet = Convert.ToInt32(item.Elements("Kerulet").FirstOrDefault().Value.ToString()),
                        Lift = (item.Elements("Lift").FirstOrDefault().Value.ToString() == "Van") ? true : false,
                        SzobakSzama = Convert.ToDouble(item.Elements("SzobakSzama").FirstOrDefault().Value.ToString()),
                        Alapterulet = Convert.ToInt32(item.Elements("Alapterulet").FirstOrDefault().Value.ToString()),
                        Ar = Convert.ToDouble(item.Elements("Ar").FirstOrDefault().Value.ToString()),
                    };
                    FlatData.Add(data);
                }
            }
            catch (Exception e)
            {
                errrorMesseges.Text = e.Message;
                throw new Exception(e.Message);
            }
            productTextBox1.Text = FlatData.Count.ToString();
        }

        //kijelölt elemek törlése a FlatData-ból.
        private void button1_Click(object sender, EventArgs e)
        {
            var flatdata = FlatData
                .Where(f => f.Lift == Convert.ToBoolean(liftComboBox1.SelectedValue))
                .ToList();

            foreach (var item in keruletListBox1.CheckedItems)
            {
                flatdata.Where(f => f.Kerulet != Convert.ToInt32(item));
            }

            foreach (var item in szobaSzamListBox2.CheckedItems)
            {
                flatdata.Where(f => f.SzobakSzama != Convert.ToInt32(item));
            }
            productTextBox1.Text = flatdata.Count.ToString();
            FlatData = flatdata;
        }

        //Adat Exportálás
        private void openWriteFileButton_Click(object sender, EventArgs e)
        {
            WriteFile file = new WriteFile(FlatData);
            file.ShowDialog();
            this.Close();
        }

        //Újboli importálás
        private void importDataButton_Click(object sender, EventArgs e)
        {
            ReadFile file = new ReadFile();
            file.ShowDialog();
            this.Close();

        }
    }
}
