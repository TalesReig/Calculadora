using System;

namespace Calculadora.ConsoleApp
{
    internal class Calculadora
    {       
        string teste;
        public ValoresDasOperacaoes[] historico = new ValoresDasOperacaoes[100];

        public void StarCalculadora()
        {
            do
            {
                ValoresDasOperacaoes valores = new ValoresDasOperacaoes();

                EscolhaOperacao(valores);

                LerOPrimeiroValor(valores);

                LerOSegundoValor(valores);

                EfetuarOperacao(valores);

                do
                {
                    Console.Write("Deseja fazer mais uma operação digite on, caso contrário off: ");
                    teste = Console.ReadLine();
                } while (teste != "on" && teste != "off");

                AdiconaObjetoNoVetor(valores);

            } while (teste == "on");
        }

        private void AdiconaObjetoNoVetor(ValoresDasOperacaoes valores)
        {
            for (int i = 0; i < historico.Length; i++)
            {
                if (historico[i] == null)
                {
                    historico[i] = valores;
                    break;
                }
            }
        }

        public void VisualizarHistoricoDeOperacoes()
        {
            Console.Clear();
            Console.WriteLine("Histórico de Operações:");
            for (int i = 0; i < historico.Length; i++)
            {
                if(historico[i] != null)
                {
                    Console.WriteLine(historico[i].numero1+ " " + historico[i].operacao +" "+ historico[i].numero2+" = "+ historico[i].resultado);
                }
            }
        }

        private static void EfetuarOperacao(ValoresDasOperacaoes valores)
        {

            switch (valores.operacao)
            {
                case '+':
                    valores.resultado = valores.numero1 + valores.numero2;
                    Console.WriteLine("Resultado = " + Math.Round(valores.resultado, 2));
                    break;
                case '-':
                    valores.resultado = valores.numero1 - valores.numero2;
                    Console.WriteLine("Resultado = " + Math.Round(valores.resultado, 2));
                    break;
                case '*':
                    valores.resultado = valores.numero1 * valores.numero2;
                    Console.WriteLine("Resultado = " + Math.Round(valores.resultado, 2));
                    break;
                case ':':
                    valores.resultado = valores.numero1 / valores.numero2;
                    Console.WriteLine("Resultado = " + Math.Round(valores.resultado, 2));
                    break;
            }
        }

        private static void LerOSegundoValor(ValoresDasOperacaoes valores)
        {
            do
            {
                Console.Write("Digite o segundo número: ");
                valores.numero2 = Convert.ToDouble(Console.ReadLine());
                if (valores.numero2 == 0 && valores.operacao == ':')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (valores.numero1 != 0)
                    {
                        Console.WriteLine("Não é possível dividir por zero, escolha outro número:");
                    }
                    else
                    {
                        Console.WriteLine("Existem infinitos resultados para esta operação !!!");
                    }
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            } while (valores.numero2 == 0 && valores.operacao == ':');
        }

        private static void LerOPrimeiroValor(ValoresDasOperacaoes valores)
        {
            Console.Write("Digite o primeiro número: ");
            valores.numero1 = Convert.ToDouble(Console.ReadLine());
        }

        private static void EscolhaOperacao(ValoresDasOperacaoes valores)
        {
            do
            {
                Console.Write("Escola a operação q deseja realizar(+),(-),(*) ou (:): ");
                valores.operacao = Convert.ToChar(Console.ReadLine());
            } while (valores.operacao != '+' && valores.operacao != '-' && valores.operacao != '*' && valores.operacao != ':');
        }
    }
}