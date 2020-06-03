using System;

namespace Calculadora_em_C_
{
    class Program
    {
        static void Main(string[] args)
        {
           CalculadoraCientifica calc = new CalculadoraCientifica();
           Console.WriteLine("Digite uma operação no formato do ex: 65 x 3");
           calc.ControlarMetodos(Console.ReadLine());
           Console.WriteLine("Resultado: "+calc.resultado); 

           Console.WriteLine("Digite números separados por ponto e vírgula para calcular média");
           calc.CalcularMedia(Console.ReadLine());
           Console.WriteLine("Média: " +calc.resultado);


       
        }
    }
}
