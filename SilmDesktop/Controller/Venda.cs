using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlimDesktop.Controllers
{
    class Venda
    {
		public int id { get; set; }
		public int idcliente { get; set; }
		public DateTime datavenda { get; set; }
		public double total { get; set; }
	}
}
