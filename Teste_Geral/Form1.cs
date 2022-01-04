using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Teste_Geral
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //SomaDeValores();
            //ListaArquivo();
            //LerArquivoXML();
        }

        private void SomaDeValores()
        {
            int intSoma = 0;
            for (int i = 0; i <= 100; i++)
            {
                intSoma += i;
            }
            string strResultadoSoma = intSoma.ToString();
            File.WriteAllText("D:/OnlineTest/", strResultadoSoma);
        }

        private void ListaArquivo()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\elielson");
            FileInfo[] TXTFiles = di.GetFiles("*.txt");
            int intContador = di.GetFiles("*.txt").Length;
            foreach (FileInfo file in TXTFiles)
            {
                listArquivos.Items.Add(file.FullName);
                TextReader tr = new StreamReader(file.FullName);
                string meutexto = tr.ReadToEnd();

                if (meutexto.Contains(string.Format("{0:(##) #####-####}", meutexto)))
                {
                    MessageBox.Show("true");
                }
            }
            lblContador.Text = "Contem " + intContador.ToString() + " Registros!";
        }

        private void LerArquivoXML()
        {
            var arquivo = @"C:\Users\elielson\nfe.xml";
            var item = "";
            var cProd = "";
            var xprod = "";
            var qCom = "";
            var vUniCom = "";
            var vProd = "";

            using (XmlReader xml = XmlReader.Create(arquivo))
            {
                var fimItens = false;

                while (xml.Read())
                {
                    if (xml.NodeType == XmlNodeType.Element && xml.Name == "natOp")
                        txtOp.Text = xml.ReadElementString();
                    if (xml.NodeType == XmlNodeType.Element && xml.Name == "nNF")
                        txtNF.Text = xml.ReadElementString();
                    if (xml.NodeType == XmlNodeType.Element && xml.Name == "dhEmi")
                        txtEmail.Text = xml.ReadElementString();

                    if (xml.NodeType == XmlNodeType.Element && xml.Name == "det")
                    {
                        item = xml.GetAttribute("nItem");

                        cProd = "";
                        xprod = "";
                        qCom = "";
                        vUniCom = "";
                        vProd = "";
                    }
                    else if (xml.NodeType == XmlNodeType.Element && xml.Name == "total")
                        fimItens = true;

                    if (!fimItens)
                    {
                        if (xml.NodeType == XmlNodeType.Element && xml.Name == "cProd")
                            cProd = xml.ReadElementString();

                        if (xml.NodeType == XmlNodeType.Element && xml.Name == "xProd")
                            xprod = xml.ReadElementString().Replace(".", ",");

                        if (xml.NodeType == XmlNodeType.Element && xml.Name == "qCom")
                            qCom = xml.ReadElementString().Replace(".", ",");

                        if (xml.NodeType == XmlNodeType.Element && xml.Name == "vUnCom")
                            vUniCom = xml.ReadElementString();

                        if (xml.NodeType == XmlNodeType.Element && xml.Name == "vProd")
                        {
                            vProd = xml.ReadElementString().Replace(".", ",");
                            listArquivos.Items.Add(new ListViewItem(new[] { item, cProd, xprod, qCom, vUniCom.ToString(), vProd.ToString().Replace(".", ",") }));
                        }
                    }

                    if (xml.NodeType == XmlNodeType.Element && xml.Name == "vNF")
                        txtTotal.Text = xml.ReadElementString();
                }
            }
        }

        private void btnAbrixXML_Click(object sender, EventArgs e)
        {
            LerArquivoXML();
        }
    }
}
