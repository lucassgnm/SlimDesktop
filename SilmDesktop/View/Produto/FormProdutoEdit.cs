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
using SlimDesktop.Controllers;

namespace SilmDesktop.View
{
    public partial class FormProdutoEdit : MetroFramework.Forms.MetroForm
    {
        FormProduto formProduto;
        String idproduto = "";
        public FormProdutoEdit(FormProduto formProduto, String id)
        {
            InitializeComponent();
            this.formProduto = formProduto;
            this.idproduto = id;

            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/produtoPorId", "id=" + idproduto);
                JavaScriptSerializer js = new JavaScriptSerializer();
                Produto[] produtos = js.Deserialize<Produto[]>(json);

                lblId.Text = produtos[0].id.ToString();
                txtDescricao.Text = produtos[0].descricao;
                txtQtde.Text = produtos[0].qtde.ToString();
                txtValorUn.Text = produtos[0].valor.ToString("N2");
                txtCodBarras.Text = produtos[0].codbarra;

            }
            catch (Exception err)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar com o servidor. " + err);
            }
        }

        private void FormProdutoEdit_Load(object sender, EventArgs e)
        {
            
        }

        private void txtValorUn_TextChanged(object sender, EventArgs e)
        {
            PublicMethods method = new PublicMethods();
            method.converterTxtBoxParaMoeda(txtValorUn);
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEditProduto_Click(object sender, EventArgs e)
        {
            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/editarProduto",
                                                     "id=" + lblId.Text +
                                                     "&descricao=" + txtDescricao.Text +
                                                     "&valorun=" + txtValorUn.Text +
                                                     "&qtde=" + txtQtde.Text +
                                                     "&codbarra=" + txtCodBarras.Text
                                                     );
                JavaScriptSerializer js = new JavaScriptSerializer();
                Mensagem mensagem = js.Deserialize<Mensagem>(json);

                if (mensagem.code == 1)
                {
                    MessageBox.Show(mensagem.msg);
                    formProduto.carregaProdutos();
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
