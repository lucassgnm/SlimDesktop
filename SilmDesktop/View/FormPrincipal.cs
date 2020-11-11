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
using SilmDesktop.Controller;
using SilmDesktop.View.Cliente;
using SilmDesktop.View.Venda;
using SilmDesktop.View.CampanhaEmail;

namespace SilmDesktop.View
{
    public partial class FormPrincipal : MetroFramework.Forms.MetroForm
    {
        public FormPrincipal(string nomeadm)
        {
            InitializeComponent();
            lblNomeAdm.Text = nomeadm;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            carregaUltimasVendas();
            getInformacoesDash();
            Timer timer = new Timer();
            timer.Interval = (1000); // 1 sec
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            Timer timer5s = new Timer();
            timer5s.Interval = (5000); // 5 sec
            timer5s.Tick += new EventHandler(timer_Tick5s);
            timer5s.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString();
        }

        JavaScriptSerializer js = new JavaScriptSerializer();
        UltimasVendas[] vendas;

        private void timer_Tick5s(object sender, EventArgs e)
        {
            carregaUltimasVendas();
            getInformacoesDash();
        }

        public void carregaUltimasVendas()
        {
            metroListView1.Items.Clear();
            try
            {
                ApiService apiserv = new ApiService();
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/todasUltimasVendas", "");
                vendas = js.Deserialize<UltimasVendas[]>(json);
                for (int i = 0; i < vendas.Length; i++)
                {

                    string[] subitems = new string[] {
                        vendas[i].id.ToString(),
                        vendas[i].nomecliente,
                        "R$ " + vendas[i].total.ToString("N2"),
                        vendas[i].datavenda.ToString("dd'/'MM'/'yyyy HH':'mm':'ss"),
                        vendas[i].bandeira
                    };
                    ListViewItem item = new ListViewItem(subitems);
                    item.ForeColor = Color.Black;
                    if (i == 0) item.Selected = true;
                    metroListView1.Items.Add(item);
                }
            }
            catch (Exception err)
            {
                for (int i = 0; i < vendas.Length; i++)
                {

                    string[] subitems = new string[] {
                        vendas[i].id.ToString(),
                        vendas[i].nomecliente,
                        "R$ " + vendas[i].total.ToString("N2"),
                        vendas[i].datavenda.ToString("dd'/'MM'/'yyyy HH':'mm':'ss"),
                        vendas[i].bandeira
                    };
                    ListViewItem item = new ListViewItem(subitems);
                    item.ForeColor = Color.Black;
                    if (i == 0) item.Selected = true;
                    metroListView1.Items.Add(item);
                }
            }
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormProduto f = new FormProduto();
            f.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormCliente f = new FormCliente();
            f.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            FormVenda f = new FormVenda();
            f.ShowDialog();
        }

        public void getInformacoesDash()
        {
            try
            {
                ApiService apiserv = new ApiService();
                InfoDash[] info;
                var json = apiserv.fazRequisicaoPOST("https://slimws.tk/desktop/getInformacoesDash", "");
                info = js.Deserialize<InfoDash[]>(json);

                lblVendasHj.Text = info[0].vendashj.ToString();
                lblVendasTotaisHj.Text = info[0].vendastotaishj.ToString();
                lblVendasTotaisMes.Text =  info[0].vendastotaismes.ToString();
                lblTicketMedioSemanal.Text = "R$ " + info[0].ticketmediosemanal.ToString("N2");
                lblTicketMedioMensal.Text = "R$ " + info[0].ticketmediomensal.ToString("N2");
                lblTicketMedioAnual.Text = "R$ " + info[0].ticketmedioanual.ToString("N2");
            }
            catch (Exception err)
            {
                MessageBox.Show("Houve um erro ao tentar se conectar com o servidor. " + err);
            }
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            FormCampanhaEmail f = new FormCampanhaEmail();
            f.ShowDialog();
        }
    }
}
