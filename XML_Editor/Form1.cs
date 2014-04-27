using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Inkludieren des XML-Library zum Behandeln von XML-Dateien
using System.Xml;
using System.IO;

namespace XML_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        private void Form1_Load(object sender, EventArgs e)
        {           
            leseXML();
            updateBild();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            
            speichereXML();
            updateBild();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            ofdDialog.CheckFileExists = true;
            ofdDialog.ShowDialog();
            tbBild.Text = "";
            tbBild.Text = ofdDialog.FileName.ToString();
            updateBild();
           

        }

        private void btnLaden_Click(object sender, EventArgs e)
        {
            leseXML();


        }
        private void leseXML()
        {
            String pfad = @"Home.xml";
            XmlDocument docHomeXml = new XmlDocument();
            try
            {
                docHomeXml.Load(pfad);
                XmlNode node = docHomeXml.DocumentElement;

                foreach (XmlNode node1 in node.ChildNodes)
                {
                    foreach (XmlNode node2 in node1.ChildNodes)
                    {
                        if (node2.Name == "Heading")
                        {
                            tbTitel.Text = node2.InnerText.ToString();
                        }
                        if (node2.Name == "ShortText")
                        {
                            tbBeschreibung.Text = node2.InnerText.ToString();
                        }
                        if (node2.Name == "Thumbnail")
                        {
                            tbBild.Text = node2.InnerText.ToString();
                        }
                        if (node2.Name == "Text")
                        {
                            tbText.Text = node2.InnerText.ToString();
                        }

                    }
                }
            }
            catch (Exception except)
            { MessageBox.Show(except.Message); }
        }
        
        private void speichereXML()
        {
            String path = @"Home.xml";
            XmlDocument docHomeXml = new XmlDocument();

            try
            {
                docHomeXml.Load(path);
                XmlNode node = docHomeXml.DocumentElement;

                foreach (XmlNode node1 in node.ChildNodes)
                {
                    foreach (XmlNode node2 in node1.ChildNodes)
                    {
                        if (node2.Name == "Heading")
                        {
                            node2.InnerText = tbTitel.Text;
                        }
                        if (node2.Name == "ShortText")
                        {
                            node2.InnerText = tbBeschreibung.Text;
                        }
                        if (node2.Name == "Thumbnail")
                        {
                            node2.InnerText = tbBild.Text;
                        }
                        if (node2.Name == "Text")
                        {
                            node2.InnerText = tbText.Text;
                        }
                        updateBild();
                    }
                }
            }
            catch (Exception except)
            { MessageBox.Show(except.Message); }
            docHomeXml.Save(@"Home.xml");
        }  

        private void updateBild()
        {   String path = tbBild.Text.ToString();
        String[] tmp = path.Split(':');

        try
        {
            if (tmp[0] == "http" | tmp[0] == "ftp" | tmp[0] == "https")
                ibBild.Image = new Bitmap(new MemoryStream(new System.Net.WebClient().DownloadData(tbBild.Text)));
            else { MessageBox.Show("lokales Bild"); } //TO BE Optimiszed !!!!!!!
        }
            catch (Exception excep)
            { MessageBox.Show("Bild Not Found"); }
            
        }
    }
}
