using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_HW1_T3
{
    public class MiniCalc
    {
        static void Main(string[] args)
        {
            string s = "";
            foreach (var a in args)
            {
                s += a;
            }

            double rez = Convert.ToDouble(new DataTable().Compute(s, ""));
            MessageBox.Show(rez.ToString());
            //Console.WriteLine(rez);
            //Console.ReadKey();
        }
    }
}
