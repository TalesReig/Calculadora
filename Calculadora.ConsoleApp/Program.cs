using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Tales de Mileto 2.0");
            string teste;
            do {

                char operacao;
                string valido = "sim";
                double resultado = 0, n2 = 0;
                
                do
                {
                    Console.Write("Escola a operação q deseja realizar(+),(-),(*) ou (:): ");
                    operacao = Convert.ToChar(Console.ReadLine());
                } while (operacao != '+' && operacao != '-' && operacao != '*' && operacao != ':');

                Console.Write("Digite o primeiro número: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                do
                {
                    Console.Write("Digite o segundo número: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    if(n2 == 0 && operacao == ':'){
                    Console.ForegroundColor = ConsoleColor.Red;
                        if (n1 != 0) { 
                            Console.WriteLine("Não é possível dividir por zero, escolha outro número:");
                        }else
                        {
                            Console.WriteLine("Existem infinitos resultados para esta operação !!!");
                        }
                    Console.ForegroundColor = ConsoleColor.Gray;
                    }
                } while (n2 == 0 && operacao == ':');

                switch (operacao)
                {
                    case '+':
                        resultado = n1 + n2;
                        Console.WriteLine("Resultado = "+ Math.Round(resultado, 2));
                        break;
                    case '-':
                        resultado = n1 - n2;
                        Console.WriteLine("Resultado = " + Math.Round(resultado, 2));
                        break;
                    case '*':
                        resultado = n1 * n2;
                        Console.WriteLine("Resultado = " + Math.Round(resultado, 2));
                        break;
                    case ':':
                        resultado = n1 / n2;
                        Console.WriteLine("Resultado = " + Math.Round(resultado, 2));
                        break;
                }
                do
                {
                    Console.Write("Você deseja fazer mais uma operação digite on, caso contrário off: ");
                    teste = Console.ReadLine();
                } while (teste != "on" && teste != "off");
            } while (teste == "on");
        }
    }
}
