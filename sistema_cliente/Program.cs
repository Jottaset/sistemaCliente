using System;

namespace sistema_cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Bairro bairro = new Bairro();

            Console.WriteLine("Informe a Opcao: ");
            Console.WriteLine("1 - PJ\t2 - PF ");

            int tipo = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Informe o Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o Endereco: ");
            string endereco = Console.ReadLine();

            Console.WriteLine("Informe o Nome do Bairro: ");
            bairro.nome = Console.ReadLine();

            switch (tipo){
                case 1: 

                default: break;
            }
        }
    }
}
