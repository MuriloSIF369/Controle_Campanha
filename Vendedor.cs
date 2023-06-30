using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Controle_Campanha
{
    public class Vendedor
    {
        public string Nome { get; set; }
        public int CPF { get; set;}

        public Vendedor()
        {
            Console.Write("Nome: ");
            Nome = Console.ReadLine();

            Console.Write("CPF: ");
            CPF = int.Parse(Console.ReadLine());



        }
    }
}
