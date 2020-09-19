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

namespace SilmDesktop.View
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            carregaProdutos();
        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }

        private void ltvProdutos_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(ltvProdutos.SelectedItems[0].SubItems[0].Text);
        }

        private void btnbuscaProduto_Click(object sender, EventArgs e)
        {
            carregaProdutosPorNome();
        }

        private void FormProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNomeProduto.Text != "")
                {
                    carregaProdutosPorNome();
                } else
                {
                    carregaProdutos();
                }
            }
        }

        private void btnTodosProdutos_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Text = "";
            carregaProdutos();
        }

        public void carregaProdutos()
        {
            ltvProdutos.Items.Clear();
            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/todosProdutos", "");
                JavaScriptSerializer js = new JavaScriptSerializer();
                Produto[] produtos = js.Deserialize<Produto[]>(json);

                for (int i = 0; i < produtos.Length; i++)
                {
                    string[] subitems = new string[] {
                        produtos[i].id.ToString(),
                        produtos[i].descricao,
                        produtos[i].qtde.ToString(),
                        "R$ " + produtos[i].valor.ToString("N2")
                    };
                    ListViewItem item = new ListViewItem(subitems);
                    ltvProdutos.Items.Add(item);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar com o servidor. " + err);
            }
        }

        public void carregaProdutosPorNome()
        {
            ltvProdutos.Items.Clear();
            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/todosProdutosPorNome", "nome=" + txtNomeProduto.Text);
                JavaScriptSerializer js = new JavaScriptSerializer();
                Produto[] produtos = js.Deserialize<Produto[]>(json);

                for (int i = 0; i < produtos.Length; i++)
                {
                    string[] subitems = new string[] {
                        produtos[i].id.ToString(),
                        produtos[i].descricao,
                        produtos[i].qtde.ToString(),
                        "R$ " + produtos[i].valor.ToString("N2")
                    };
                    ListViewItem item = new ListViewItem(subitems);
                    ltvProdutos.Items.Add(item);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar com o servidor. " + err);
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormProdutoAdd f = new FormProdutoAdd(this);
            f.ShowDialog();
        }

        private void ltvProdutos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (ltvProdutos.FocusedItem.Bounds.Contains(e.Location))
                {
                    metroContextMenu1.Show(Cursor.Position);
                }
            }
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void testeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o produto: "+ ltvProdutos.SelectedItems[0].SubItems[1].Text  + "?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/excluirProduto", "id=" + ltvProdutos.SelectedItems[0].SubItems[0].Text);
                JavaScriptSerializer js = new JavaScriptSerializer();
                Mensagem mensagem = js.Deserialize<Mensagem>(json);
                carregaProdutos();
                MessageBox.Show(mensagem.msg);
            }
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutoEdit f = new FormProdutoEdit(this, ltvProdutos.SelectedItems[0].SubItems[0].Text);
            f.ShowDialog();
        }
    }
}
