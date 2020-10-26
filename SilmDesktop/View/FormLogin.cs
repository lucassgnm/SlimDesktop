using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Examples.System.Net;
using SilmDesktop.View;
using SlimDesktop.Controllers;

namespace SilmDesktop
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Activate();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            verificaLogin();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                verificaLogin();
            }
        }

        private void verificaLogin()
        {
            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/administradorExiste", "email=" + txtEmail.Text + "&senha=" + txtSenha.Text);
                JavaScriptSerializer js = new JavaScriptSerializer();
                Mensagem mensagem = js.Deserialize<Mensagem>(json);

                if (mensagem.code == 1)
                {
                    this.Hide();
                    FormPrincipal f = new FormPrincipal(mensagem.msg);
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }
                else
                {
                    txtEmail.Text = "";
                    txtSenha.Text = "";
                    txtEmail.Focus();
                    MessageBox.Show(mensagem.msg);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar com o servidor. " + err);
            }
        }
    }
}
