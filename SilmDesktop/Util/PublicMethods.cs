using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using SilmDesktop.View;

namespace SilmDesktop.Util
{
    public class PublicMethods
    {
        public void converterTxtBoxParaMoeda(MetroTextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch
            {

            }
        }

        private FormLoad f;

        public void Preload()
        {
            f = new FormLoad();
            f.ShowDialog();
        }

        public void UnPreload()
        {
            f.Hide();
        }

    }
}
