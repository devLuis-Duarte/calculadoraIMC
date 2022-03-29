using System;

namespace calculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua altura em metros?");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Qual o seu peso?");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = peso /(altura * altura);

            Console.WriteLine("{0} sua altura eh {1} seu peso {2}", nome, altura, peso);
            Console.WriteLine("{0} seu IMC ", imc);
        }
    }
}
