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
using System.Xml;
using System.Xml.Linq;

namespace IRF_Projekt_Beadando
{
    public partial class Form1 : Form
    {
        public List<Data> Data { get; set; } 

        public Form1(string filePath)
        {
            InitializeComponent();
            FileReading(filePath);
        }

        public Form1()
        {
            InitializeComponent();
        }


        public void FileReading(string fileName)
        {
            Data data = new Data();
            XElement file = XElement.Load(fileName);

            var ta = file;

            IEnumerable<XElement> pricesByPartNos = file.Descendants("record").Descendants("Kod");
            var a = pricesByPartNos;



            //using (XmlReader reader = XmlReader.Create(fileName))
            //{
            //    while (reader.Read())
            //    {
            //        if (reader.IsStartElement())
            //        {
            //            switch (reader.Name)
            //            {
            //                case "Kod":
            //                    // Detect this ele
            //                    var a = reader.Value.Trim();
            //                    break;

            //            }
            //        }
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Vissza lépés
        private void openWriteFileButton_Click(object sender, EventArgs e)
        {
            WriteFile file = new WriteFile();
            file.ShowDialog();
            this.Close();
        }

        //Tovább haladás
        private void importDataButton_Click(object sender, EventArgs e)
        {
            ReadFile file = new ReadFile(); //vm
            file.ShowDialog();
            this.Close();
        }
    }
}
