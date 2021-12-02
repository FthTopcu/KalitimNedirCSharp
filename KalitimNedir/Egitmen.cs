using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimNedir
{
    sealed class Egitmen:TemelTip
    {
        public string brans { get; set; }
        public int bransSeviye { get; set; }
        public Egitmen()
        {
            Console.WriteLine("Egitmen nesnesine erişildi.");
        }
    }
}
