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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            carregarClientes();
        }

        public void carregarClientes()
        {
            ltvClientes.Items.Clear();
            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/todosClientes", "");
                JavaScriptSerializer js = new JavaScriptSerializer();
                Clientes[] clientes = js.Deserialize<Clientes[]>(json);

                for (int i = 0; i < clientes.Length; i++)
                {
                    string[] subitems = new string[] {
                        clientes[i].id.ToString(),
                        clientes[i].nome,
                        clientes[i].email,
                        FormatCnpjCpf.FormatCPF(clientes[i].cpf),
                       FormatCnpjCpf.formatTelefone(clientes[i].telefone)
                    };
                    ListViewItem item = new ListViewItem(subitems);
                    ltvClientes.Items.Add(item);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar com o servidor. " + err);
            }
        }

        public void carregaClientesPorNome()
        {
            ltvClientes.Items.Clear();
            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/todosClientesPorNome", "nome=" + txtNomeCliente.Text);
                JavaScriptSerializer js = new JavaScriptSerializer();
                Clientes[] clientes = js.Deserialize<Clientes[]>(json);

                for (int i = 0; i < clientes.Length; i++)
                {
                    string[] subitems = new string[] {
                        clientes[i].id.ToString(),
                        clientes[i].nome,
                        clientes[i].email,
                        FormatCnpjCpf.FormatCPF(clientes[i].cpf),
                        FormatCnpjCpf.formatTelefone(clientes[i].telefone)
                    };
                    ListViewItem item = new ListViewItem(subitems);
                    ltvClientes.Items.Add(item);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar com o servidor. " + err);
            }
        }

        private void btnbuscaCliente_Click(object sender, EventArgs e)
        {
            carregaClientesPorNome();
        }

        private void FormCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNomeCliente.Text != "")
                {
                    carregaClientesPorNome();
                }
                else
                {
                    carregarClientes();
                }
            }
        }

        private void ltvClientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (ltvClientes.FocusedItem.Bounds.Contains(e.Location))
                {
                    metroContextMenu1.Show(Cursor.Position);
                }
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteEdit f = new FormClienteEdit(this, ltvClientes.SelectedItems[0].SubItems[0].Text);
            f.ShowDialog();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o cliente: " + ltvClientes.SelectedItems[0].SubItems[1].Text + "?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/excluirCliente", "id=" + ltvClientes.SelectedItems[0].SubItems[0].Text);
                JavaScriptSerializer js = new JavaScriptSerializer();
                Mensagem mensagem = js.Deserialize<Mensagem>(json);
                carregarClientes();
                MessageBox.Show(mensagem.msg);
            }
        }
    }
}