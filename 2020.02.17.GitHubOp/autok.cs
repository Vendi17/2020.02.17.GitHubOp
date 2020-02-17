using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2020._02._17.GitHubOp
{
    class autok
    {
        private List<auto> AutoLista = new List<auto>();
        public autok(string fName)
        {
            using (StreamReader sr = new StreamReader(fName))
            {
                sr.ReadLine();
            }

        }
    }
}
