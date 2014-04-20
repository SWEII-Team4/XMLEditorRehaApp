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


namespace XML_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc;
        String path;

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlTextReader datenLesen = new XmlTextReader("Home.xml");
            XmlTextWriter datenSchreiben = new XmlTextWriter("Home.xml",Encoding.UTF8); 
            XmlNodeType typ = new XmlNodeType();
            


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
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {

            XmlTextReader datenLesen = new XmlTextReader("Home.xml");
            XmlNodeType typ = new XmlNodeType();
            

            while(true)
            {
                typ = datenLesen.NodeType;

                if(typ == XmlNodeType.Element)
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
               







           
        }


 
    }
}
