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
using MetroFramework.Controls;
using SilmDesktop.Util;
using SlimDesktop.Controllers;
using WaitFormExample;

namespace SilmDesktop.View
{
    public partial class FormProdutoAdd : MetroFramework.Forms.MetroForm
    {
        FormProduto formProduto;
        public FormProdutoAdd(FormProduto formProduto)
        {
            InitializeComponent();
            this.formProduto = formProduto;
        }

        private void FormProdutoAdd_Load(object sender, EventArgs e)
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

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/adicionarProduto", 
                                                     "descricao=" + txtDescricao.Text + 
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
