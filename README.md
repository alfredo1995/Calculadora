# Calculadora
Calculadora simples usando Switch em C# 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    public class CalculadoraSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Digite o primeiro numero");
            int.TryParse(Console.ReadLine(), out int primeiroValor);

            Console.WriteLine("Digite o segundo numero");
            int.TryParse(Console.ReadLine(), out int segundoValor);

            Console.WriteLine("Digite 1 para adição, 2 para subtração, 3 para divisao e 4 para multiplicação");
            int.TryParse(Console.ReadLine(), out int operacao);

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = primeiroValor + segundoValor;
                    Console.WriteLine(resultado);
                    break;
                case 2:
                    resultado = primeiroValor - segundoValor;
                    Console.WriteLine(resultado);
                    break;
                case 3:
                    resultado = primeiroValor / segundoValor;
                    Console.WriteLine(resultado);
                    break;
                case 4:
                    resultado = primeiroValor * segundoValor;
                    Console.WriteLine(resultado);
                    break;
                default:
                    Console.WriteLine("Numero digitato e invalido");
                    break;
            }

        }
    }
}
