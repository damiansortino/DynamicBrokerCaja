using System;
using System.Configuration;
using System.Windows.Forms;
using System.Xml;

namespace DynamicBrokerCaja.Views
{
    public partial class ConfigIPServer : Form
    {
        public ConfigIPServer()
        {
            InitializeComponent();
        }

        private void ConfigIPServer_Load(object sender, EventArgs e)
        {
            tb_editarip.Text = ConfigurationManager.ConnectionStrings["DynamicBrokerEntities"].ConnectionString;
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement elementos in xmldoc.DocumentElement)
            {
                if (elementos.Name.Equals("connectionStrings"))
                {
                    foreach (XmlNode nodo in elementos.ChildNodes)
                    {
                        if (nodo.Attributes["name"].Value.Equals("DynamicBrokerEntities"))
                        {
                            nodo.Attributes["connectionString"].Value = tb_editarip.Text.Trim();
                            MessageBox.Show("Modificado Correctamente");
                        }
                    }
                }
            }

            xmldoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionStrings");
            this.Close();
        }
    }
}
