internal class Program
{
    private static void Main(string[] args)
    {
        int op = 1;

        do
        {
            Console.WriteLine(">> Sequencia de números <<");
            double[] v = EscolheNumeros();
            Imprime(EscolheMaior(v), EscolheMenor(v));

            Console.WriteLine("Gostaria de informar uma nova sequencia de números?\n[1 - sim]\n[2 - não (Sair)]");
            if (!int.TryParse(Console.ReadLine(), out op))
            {
                Console.WriteLine("Valor inválido, digite uma opção válida");
                continue;
            }
            if(op == 2)
            {
                op = 2;
                Console.WriteLine("Saindo..");
            }
            if(op < 1 || op > 2)
            {
                Console.WriteLine("Valor inválido, digite uma opção válida");
                continue;
            }
         } while (op == 1);
    }

    static double[] EscolheNumeros()
    {
        double[] vetor = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Insira o numero");
            if(!double.TryParse(Console.ReadLine(), out vetor[i]))
            {
                Console.WriteLine("Valor inválido, digite um valor válido.");
                continue;
            }

             
        }
            return vetor;
    }

    static double EscolheMaior(double[] vetor)
    {
        double maior = vetor[0];

        for (int i = 0; i < 5; i++)
        {
            if (maior < vetor[i])
            {
                maior = vetor[i];
            }
        }
        return maior;
    }

    static double EscolheMenor(double[] vetor)
    {
        double menor = vetor[0];

        for (int i = 0; i < 5; i++)
        {
            if (menor > vetor[i])
            {
                menor = vetor[i];
            }
        }
        return menor;
    }

    static void Imprime(double maior, double menor)
    {
        Console.WriteLine("Maior numero: " + maior + ", e menor : " + menor);
    }
}



