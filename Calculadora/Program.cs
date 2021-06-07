using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro Valor!");
            int primeiroValor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo Valor!");
            int segundoValor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 para divisao, 2 para multiplicao, 3 para adicao, 4 para subtracao");
            int operacao = Convert.ToInt32(Console.ReadLine());

            if (operacao == 1)
            {
                int resultado = primeiroValor / segundoValor;
                Console.WriteLine(resultado);
            }
            else if (operacao == 2)
            {
                int resultado = primeiroValor * segundoValor;
                Console.WriteLine(resultado);
            }
            else if (operacao == 3)
            {
                int resultado = primeiroValor + segundoValor;
                Console.WriteLine(resultado);
            }
            else if (operacao == 4)
            {
                int resultado = primeiroValor - segundoValor;
                Console.WriteLine(resultado);
            }

        
    }
    }
}



