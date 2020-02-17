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
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lineArr = line.Split(';');
                    auto uj = new auto(lineArr[0],lineArr[1] , Convert.ToInt32(lineArr[2]) , Convert.ToInt32(lineArr[3]) , lineArr[4] , Convert.ToInt32(lineArr[5]));
                    AutoLista.Add(uj);
                    
                }
            }

        }
        public int howmanyCarsAreThere()
        {
            return AutoLista.Count;
        }
    }
}
