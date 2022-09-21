using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DynamicBrokerCaja.Views
{
    public partial class ConfigInterParana : Form
    {
        public ConfigInterParana()
        {
            InitializeComponent();
        }

        private void ConfigInterParana_Load(object sender, EventArgs e)
        {
            tbCarpeta.Text = ConfigurationManager.ConnectionStrings["InterfazParana"].ConnectionString;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            fbd_BuscarCarpeta.ShowDialog();
            tbCarpeta.Text = fbd_BuscarCarpeta.SelectedPath.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            XmlDocument documento = new XmlDocument();
            documento.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement item in documento.DocumentElement)
            {
                if (item.Name == "connectionStrings")
                {
                    foreach (XmlNode item2 in item.ChildNodes)
                    {
                        if (item2.Attributes["name"].Value == "InterfazParana")
                        {
                            item2.Attributes["connectionString"].Value = fbd_BuscarCarpeta.SelectedPath.ToString();

                        }

                    }

                }
            }
            documento.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionStrings");
            MessageBox.Show("Carpeta de configuración actualizada correctamente");
            this.Close();
        }
    }
}
