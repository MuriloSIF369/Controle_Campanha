using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Campanha
{
    public class Premio
    {
        public int Codigo { get; set; }
        public string Descricão { get; set; }

        public Premio()
        {
            Console.Write("Código do prêmio: ");
            Codigo = int.Parse(Console.ReadLine());

            Console.Write("Descrição do Prêmio: ");
            Descricão = Console.ReadLine();
        }
    }
}
