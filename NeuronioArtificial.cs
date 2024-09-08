using System.Globalization;
using System.Reflection;

namespace Perceptron
{
    public class NeuronioArtificial
    {
        public Pesos Pesos { get; set; }

        public double O { get; private set; }

        public double TaxaAprendizado { get; private set; }

        public NeuronioArtificial()
        {
            O = 0.0;
            TaxaAprendizado = 0.5;
            Pesos = new Pesos();
        }

        public void Treinar(List<Entradas> listaEntradas, int testes)
        {
            for (int i = 0; i < testes; i++)
            {
                double entrada1 = Perguntar(i, 1);
                double entrada2 = Perguntar(i, 2);

                Console.WriteLine("\nQual o resultado esperado?");
                int resultadoEsperado = Convert.ToInt32(Console.ReadLine());

                Entradas novaEntrada = new(entrada1, entrada2, resultadoEsperado);

                listaEntradas.Add(novaEntrada);
            }

            foreach (var item in listaEntradas)
            {
                var pesoAntigo1 = Pesos.W1;
                var pesoAntigo2 = Pesos.W2;

                O = item.Entrada1 * Pesos.W1 + item.Entrada2 * Pesos.W2;

                int resultObtido = FuncaoClassificacao(O);
                int resultCalculoErro = CalcularErro(resultObtido, item.ResultadoEsperado);

                if (FuncaoClassificacao(O) != item.ResultadoEsperado)
                {
                    Pesos.W1 = RecalcularNovoPeso(Pesos.W1, resultCalculoErro, item.Entrada1);
                    Pesos.W2 = RecalcularNovoPeso(Pesos.W2, resultCalculoErro, item.Entrada2);
                }

                Printar.Print(item.Entrada1, item.Entrada2, pesoAntigo1, pesoAntigo2,
                    item.ResultadoEsperado, O, resultObtido, resultCalculoErro, Pesos.W1, Pesos.W2);
            }
        }

        private int FuncaoClassificacao(double o)
        {
            if (o >= 0) return 1; return 0;
        }

        private int CalcularErro(int resultObtido, int resultEsperado)
        {
            return resultEsperado - resultObtido;
        }

        private double RecalcularNovoPeso(double peso, int calculoErro, double entrada)
        {
            double resultNovoPeso = (peso + TaxaAprendizado) * calculoErro * entrada;

            return resultNovoPeso;
        }

        public double Perguntar(int posicao, int identificador)
        {
            Console.WriteLine($"\nDigite a entrada {identificador} do elemento {posicao + 1}:");
            double entrada = Convert.ToDouble(Console.ReadLine());

            return entrada;
        }
    }
}