using System;

namespace APPControlePedidos
{
    class Program
    {
        static void Main(string[] args)
        {

            string usu;
            int sen;

            Login log = new Login();
            Console.WriteLine("Bem Vindo, Digite seu Usuario e Senha\n");
            usu = Console.ReadLine();
            sen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            log.verificarLogin(usu, sen);
        }
    }
}
