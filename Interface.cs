using System;
using System.Collections.Generic;
using System.Text;

namespace APPControlePedidos
{
    class Interface
    {
        string entrada;

        public void exibirOpcoes()
        {
            Console.WriteLine("1- Exibir lista Completa de Pedidos");
            Console.WriteLine("2- Novo Pedido");
            Console.WriteLine("3- Cancelar Pedido");
            Console.WriteLine("4- Dar Saída em Pedido");
            Console.WriteLine("5- Gerar Relatorio de materiais Totais");
            Console.WriteLine("6- Gerar Relatorio de materiais Gastos");
            Console.WriteLine("7- Gerar Relatorio de materiais Faltantes");
            Console.WriteLine("8- Sair.");
            Console.WriteLine("\n");
        }

        public void exibirConcessionaria()
        {
            Console.WriteLine("1- Escelsa");
            Console.WriteLine("2- Light");
            Console.WriteLine("3- Coelba");
            Console.WriteLine("4- Energisa");
        }

        public void exibirListaPedidos()
        {
            Console.Clear();
            Console.WriteLine("Todos os pedidos em andamento:\n");
        }

        public void entradaPedido() 
        {
            Console.Clear();
            Console.WriteLine("Você está dando entrada em um novo Pedido\n");
            Console.WriteLine("Escolha a Concessionaria:\n");
            exibirConcessionaria();
            Console.WriteLine("\n");
            Console.WriteLine("Digite o número correspondente a qual deseja escolher.\n");
            entrada = Console.ReadLine();

        }

        public void cancelamentoPedido()
        {
            Console.Clear();
            Console.WriteLine("Você está dando cancelando um Pedido\n");
        }

        public void saidaPedido()
        {
            Console.Clear();
            Console.WriteLine("Você está dando saída em um Pedido\n");
        }

    }
}
