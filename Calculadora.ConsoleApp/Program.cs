using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calculadora calculadora = new Calculadora();

            calculadora.StarCalculadora();
            calculadora.VisualizarHistoricoDeOperacoes();
        }
    }
}
