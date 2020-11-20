using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Examples.System.Net;
using SilmDesktop.Util;

namespace SilmDesktop.View.CampanhaEmail
{
    public partial class FormCampanhaEmail : MetroFramework.Forms.MetroForm
    {
        public FormCampanhaEmail()
        {
            InitializeComponent();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            PublicMethods method = new PublicMethods();
            try
            {
                string assunto = txtAssunto.Text;
                string corpo = txtCorpo.Text;
                if (assunto != "" || corpo != "")
                {
                    ApiService apiserv = new ApiService();
                    var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/enviarEmail", "assunto=" + txtAssunto.Text + "&txt=" + txtCorpo.Text);
                    JavaScriptSerializer js = new JavaScriptSerializer();

                    MessageBox.Show("Emails enviados para fila. Em poucos instantes finalizaremos o processo.");
                    
                }
                else
                {
                    MessageBox.Show("Por favor preencha todos os campos.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar com o servidor. " + err);
            }
        }

        private void FormCampanhaEmail_Load(object sender, EventArgs e)
        {
            txtAssunto.Focus();
            txtAssunto.Select();
        }
    }
}
