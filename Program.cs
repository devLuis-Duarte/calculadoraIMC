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

            double imc = Math.Round(peso /(altura * altura), 2);

            Console.WriteLine("{0} sua altura eh {1} seu peso {2}", nome, altura, peso);
            Console.WriteLine("{0} seu IMC ", imc);

            if(imc <17){
                Console.WriteLine("sua situacao e muito abaixo do peso");
            } else if(imc >=17.00 && imc < 18.50){
                Console.WriteLine("sua situacao e abaixo do peso");
            } else if(imc >=18.50 && imc <25.00){
                Console.WriteLine("sua situacao e peso normal");
            } else if(imc >=25.00 && imc >= 30.00){
                Console.WriteLine("sua situacao e acima de peso");
            } else if (imc >=30.00 && imc <35.00){
                Console.WriteLine("sua situacao e obesidade 1 ");
            } else if(imc >= 35.00 && imc <40.00){
                Console.WriteLine("sua situacao e obesidade 2");
            } else {
                Console.WriteLine("sua situacao e obesidade 3");
            }
        }
    }
}
