public class Individuo{
    public string Nome{get; set;}
    public double Altura{get; set;}
    public  double Peso{get; set;}

    public Individuo(string nome, double altura, double peso){
        Nome = nome;
        Altura = altura;
        Peso = peso;

    }
    public double IMC {get => Peso/ (Altura * Altura);}

   
}