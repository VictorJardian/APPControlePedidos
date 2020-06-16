using System;

namespace APPControlePedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            string usu;
            int sen;
            int opcao = 0;

            Login log = new Login();
            Console.WriteLine("Bem Vindo, Digite seu Usuario e Senha\n");
            usu = Console.ReadLine();
            sen = Convert.ToInt32(Console.ReadLine());
            log.verificarLogin(usu, sen);
            
            Console.WriteLine("o que deseja fazer? digite o número da opcão.\n");
            Interface inter = new Interface();
            inter.exibirOpcoes();
            opcao = Convert.ToInt32(Console.ReadLine());
            Relatorios rel = new Relatorios();

            if (opcao == 1)
            {
                inter.exibirListaPedidos();
            }

            if (opcao == 2)
            {
                inter.entradaPedido();
            }

            if (opcao == 3)
            {
                inter.cancelamentoPedido();
            }

            if (opcao == 4)
            {
                inter.saidaPedido();
            }

            if (opcao == 5)
            {
                rel.relatorioMatTotal();
            }

            if (opcao == 6)
            {
                rel.relatorioMatGasto();
            }

            if (opcao == 7)
            {
                rel.relatorioMatFaltante();
            }

            if (opcao == 8)
            {
               
            }

        }
    }
}
