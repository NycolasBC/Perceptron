namespace Perceptron
{
    public class Pesos
    {
        public Pesos(double w1, double w2)
        {
            W1 = w1;
            W2 = w2;
        }

        public Pesos()
        {
            GerarAleatorio();
        }

        public double W1 { get; set; }
        public double W2 { get; set; }

        public void GerarAleatorio()
        {
            Random random = new();
            W1 = Math.Round(random.NextDouble() * 2 - 1, 3);
            W2 = Math.Round(random.NextDouble() * 2 - 1, 3);
        }
    }
}