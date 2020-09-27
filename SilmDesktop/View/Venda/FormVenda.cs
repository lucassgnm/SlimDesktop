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

namespace SilmDesktop.View.Venda
{
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
            carregaVendas();
        }

        public void carregaVendas()
        {
            ltvVenda.Items.Clear();
            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/todasVendas", "");
                JavaScriptSerializer js = new JavaScriptSerializer();
                Vendas[] vendas = js.Deserialize<Vendas[]>(json);
                for (int i = 0; i < vendas.Length; i++)
                {
                    var status = "";
                    if (vendas[i].status == 1)
                        status = "Aberta";
                    else
                        status = "Fechada";
                    
                    string[] subitems = new string[] {
                        vendas[i].id.ToString(),
                        vendas[i].nomecliente,
                        "R$ " + vendas[i].total.ToString("N2"),
                        vendas[i].datavenda.ToString("dd'/'MM'/'yyyy HH':'mm':'ss"),
                        status
                    };
                    ListViewItem item = new ListViewItem(subitems);
                    ltvVenda.Items.Add(item);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar com o servidor. " + err);
            }
        }
        public void carregaVendasPorId()
        {
            ltvVenda.Items.Clear();
            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/todasVendasPorId", "id=" + txtIdVenda.Text);
                JavaScriptSerializer js = new JavaScriptSerializer();
                Vendas[] vendas = js.Deserialize<Vendas[]>(json);

                for (int i = 0; i < vendas.Length; i++)
                {
                    var status = "";
                    if (vendas[i].status == 1)
                        status = "Aberta";
                    else
                        status = "Fechada";

                    string[] subitems = new string[] {
                        vendas[i].id.ToString(),
                        vendas[i].nomecliente,
                        "R$ " + vendas[i].total.ToString("N2"),
                        vendas[i].datavenda.ToString("dd'/'MM'/'yyyy HH':'mm':'ss"),
                        status
                    };
                    ListViewItem item = new ListViewItem(subitems);
                    ltvVenda.Items.Add(item);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar com o servidor. " + err);
            }
        }

        private void btnbuscaProduto_Click(object sender, EventArgs e)
        {
            carregaVendasPorId();
        }

        private void btnTodosProdutos_Click(object sender, EventArgs e)
        {
            carregaVendas();
        }

        private void FormVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtIdVenda.Text != "")
                {
                    carregaVendasPorId();
                }
                else
                {
                    carregaVendas();
                }
            }
        }

        private void FormVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
