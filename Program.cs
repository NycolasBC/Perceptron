using Perceptron;

NeuronioArtificial neuronioArtificial = new();
List<Entradas> entradas = [];

Console.WriteLine("Quantos testes serão realizados?");
int testes = Convert.ToInt32(Console.ReadLine());

neuronioArtificial.Treinar(entradas, testes);

Console.Read();