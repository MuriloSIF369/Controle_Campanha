using Controle_Campanha;
using System.ComponentModel.Design;
using System.Data;
using System.IO.Pipes;

public class Program
{
    public static void Main(string[] args)
    {

        List<Vendedor> ListaVendedor = new List<Vendedor>();
        List<Premio> ListaPremio = new List<Premio>();
        List<Campanha> ListaCampanha = new List<Campanha>();


    Menu:

        Console.WriteLine("_ MENU DE OPÇÕES _\n"
        + "1. Cadastrar vendedor\n"
        + "2. Cadastrar Prêmio\n"
        + "3. Cadastrar Campanha\n"
        + "4. Pesquisar Vendedor (Por Campanha)");
        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Vendedor _vendedor = new Vendedor();
                ListaVendedor.Add(_vendedor);
                goto Menu;
                
            case 2:
                Premio _premio = new Premio();
                ListaPremio.Add(_premio);
                goto Menu;

            case 3:
                Campanha _campanha = new Campanha();
                ListaCampanha.Add(_campanha);
                
                Console.WriteLine("Escolha o prêmio da Campanha (código): \n");
                foreach (var item in ListaPremio)
                {
                    Console.WriteLine($"Cód. Prêmio: {item.Codigo}\n"
                        + $"Descrição do prêmio: {item.Descricão}\n");
                }
                Console.Write("Cód. Prêmio escolhido: ");
                int escolhapremio = int.Parse(Console.ReadLine());

                
                _premio = ((Premio)ListaPremio.Where(ListaPremio => ListaPremio.Codigo == escolhapremio));
                 

                List<Vendedor> VendedoresCampanha = new List<Vendedor>();
                foreach (var vendedor in ListaVendedor)
                {

                    VendedoresCampanha.Add(vendedor);

                }
                goto Menu;

            case 4:
                Console.Write("Nome do vendedor da campanha: ");
                string PesquisaCampanha = Console.ReadLine();
                var VendedorCampanha = ListaVendedor.Where(ListaVendedor => ListaVendedor.Nome == PesquisaCampanha);



                foreach (var item in VendedorCampanha)
                {

                    Console.WriteLine(item.Nome);
                }
                break;
        }
    }
}