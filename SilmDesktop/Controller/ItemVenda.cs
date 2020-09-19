using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlimDesktop.Controllers
{
    class ItemVenda
    {
		public int id { get; set; }
		public int idvenda { get; set; }
		public int idproduto { get; set; }
		public int qtde { get; set; }
		public double valorun { get; set; }
		public double valortotal { get; set; }
	}
}
