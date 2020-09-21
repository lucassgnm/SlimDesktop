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
using SlimDesktop.Controllers;

namespace SilmDesktop.View.Cliente
{
    public partial class FormClienteEdit : MetroFramework.Forms.MetroForm
    {
        FormCliente formCliente;
        String idcliente = "";
        public FormClienteEdit(FormCliente formCliente, String id)
        {
            InitializeComponent();
            this.formCliente = formCliente;
            this.idcliente = id;

            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/clientePorId", "id=" + idcliente);
                JavaScriptSerializer js = new JavaScriptSerializer();
                Clientes[] clientes = js.Deserialize<Clientes[]>(json);

                lblId.Text = clientes[0].id.ToString();
                txtNome.Text = clientes[0].nome;
                txtEmail.Text = clientes[0].email;
                txtCpf.Text = clientes[0].cpf;
                txtTelefone.Text = clientes[0].telefone;

            }
            catch (Exception err)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar com o servidor. " + err);
            }
        }

        private void FormClienteEdit_Load(object sender, EventArgs e)
        {

        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEditCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/editarCliente",
                                                     "id=" + lblId.Text +
                                                     "&nome=" + txtNome.Text +
                                                     "&email=" + txtEmail.Text +
                                                     "&cpf=" + txtCpf.Text +
                                                     "&telefone=" + txtTelefone.Text
                                                     );
                JavaScriptSerializer js = new JavaScriptSerializer();
                Mensagem mensagem = js.Deserialize<Mensagem>(json);

                if (mensagem.code == 1)
                {
                    MessageBox.Show(mensagem.msg);
                    formCliente.carregarClientes();
                    this.Hide();
                }
                else
                {
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
