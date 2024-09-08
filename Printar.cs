namespace Perceptron
{
    public class Printar
    {
        public static void Print(double entrada1, double entrada2, double pesoAntigo1, double pesoAntigo2,
            int resultadoEsperado, double o, int resultObtido, int resultCalculoErro, double peso1, double peso2)
        {
            Console.WriteLine();

            Console.WriteLine($"Entrada 1 = {entrada1}");
            Console.WriteLine($"Entrada 2 = {entrada2}");
            Console.WriteLine($"Peso 1 = {pesoAntigo1}");
            Console.WriteLine($"Peso 2 = {pesoAntigo2}");
            Console.WriteLine($"Resultado Obtido = {o}");
            Console.WriteLine($"Classificacao Obtida = {resultObtido}");
            Console.WriteLine($"Resultado Esperado = {resultadoEsperado}");
            Console.WriteLine($"Taxa de Treinamento = 0.5");
            Console.WriteLine($"Novo Peso 1 = {peso1}");
            Console.WriteLine($"Novo Peso 2 = {peso2}");

            Console.WriteLine();
        }
    }
}