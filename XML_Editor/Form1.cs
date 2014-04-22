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
            String[] arrXmlElemente = new String[4] { "Heading", "ShortText", "Thumbnail", "Text" };
            TextBox[] arrTextBoxes = new TextBox[4] {tbTitel,tbBeschreibung,tbBild,tbText};
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
                            tbTitel.Text = node2.InnerText;
                        }
                        if (node2.Name == "ShortText")
                        {
                            tbBeschreibung.Text = node2.InnerText;
                        }
                        if (node2.Name == "Thumbnail")
                        {
                            tbBild.Text = node2.InnerText;
                        }
                        if (node2.Name == "Text")
                        {                           
                            tbText.Text = node2.InnerText;
                        }
                        
                    }
                }
            }catch(Exception except)
            { MessageBox.Show(except.Message); }
        }
/*  
            while (datenLesen.Read())
            {
                typ = datenLesen.NodeType;

                if (typ == XmlNodeType.Element)
                {
                    if (datenLesen.Name == "Heading")
                    {
                        datenLesen.Read();
                        tbTitel.Text = datenLesen.Value;
                    }
                    if (datenLesen.Name == "ShortText")
                    {
                        datenLesen.Read();
                        tbBeschreibung.Text = datenLesen.Value;
                    }
                    if (datenLesen.Name == "Thumbnail")
                    {
                        datenLesen.Read();
                        tbBild.Text = datenLesen.Value;
                    }
                    if (datenLesen.Name == "Text")
                    {
                        datenLesen.Read();
                        tbText.Text = datenLesen.Value;
                    }
                }
            }
        }*/

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            String[] arrXmlElemente = new String[4] { "Heading", "ShortText", "Thumbnail", "Text" };
            TextBox[] arrTextBoxes = new TextBox[4] { tbTitel, tbBeschreibung, tbBild, tbText };
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
                            node2.InnerText =tbTitel.Text ;
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

                    }
                }
            }
            catch (Exception except)
            { MessageBox.Show(except.Message); }
            docHomeXml.Save(@"Home.xml");
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            ofdDialog.CheckFileExists = true;
            ofdDialog.ShowDialog();
            tbBild.Text = "";
            tbBild.Text = ofdDialog.FileName;
            ibBild.Image = Image.FromFile(ofdDialog.FileName);

        }

       


 
    }
}
