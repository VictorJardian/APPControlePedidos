using System;
using System.Collections.Generic;
using System.Text;

namespace APPControlePedidos
{
    class Interface
    {
        public void exibirOpcoes()
        {
            Console.WriteLine("1- Cadastrar novo Pedido");
            Console.WriteLine("2- Ver lista Completa de Pedidos");
            Console.WriteLine("3- Gerar Relatorio de materiais Totais");
            Console.WriteLine("4- Gerar Relatorio de materiais Gastos");
            Console.WriteLine("5- Gerar Relatorio de materiais Faltantes");
            Console.WriteLine("6- Sair.");
            Console.WriteLine("\n");
        }
    }
}
