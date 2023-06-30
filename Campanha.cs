using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Campanha
{
    internal class Campanha : Program
    {
        public string inicio{ get; set; }
        public string fim { get; set; }
        public Premio premio { get; set; }

        public Campanha()
        {
            Console.Write("Data de início: ");
            inicio = (Console.ReadLine());

            Console.Write("Data de Finalização: ");
            fim = (Console.ReadLine());

            


        }
    }
}
