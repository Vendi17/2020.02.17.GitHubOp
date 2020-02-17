using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020._02._17.GitHubOp
{
    class auto
    {
        private string _marka;
        private string _modell;
        private int _evjarat;
        private int _kilometerek;
        private string _uzemanyagTipus;
        private int _autoAr;

        public auto(string marka, string modell, int evjarat, int kilometerek, string uzemanyagTipus, int autoAr)
        {
            Marka = marka;
            Modell = modell;
            Evjarat = evjarat;
            Kilometerek = kilometerek;
            UzemanyagTipus = uzemanyagTipus;
            AutoAr = autoAr;
        }

        public string Marka { get => _marka; set => _marka = value; }
        public string Modell { get => _modell; set => _modell = value; }
        public int Evjarat { get => _evjarat; set => _evjarat = value; }
        public int Kilometerek { get => _kilometerek; set => _kilometerek = value; }
        public string UzemanyagTipus { get => _uzemanyagTipus; set => _uzemanyagTipus = value; }
        public int AutoAr { get => _autoAr; set => _autoAr = value; }

        public override string ToString()
        {
            return string.Format("{0,20}" + "{1,20}" + "{2,20}" + "{3,20}" + "{4,20}" + "{5,20}" + "{6,20}");
        }
    }
}
