internal class Program
{
    private static void Main(string[] args)
    {
        double numero = 0;
        double[] vetor = new double[5];
        double maior = 0;
        double menor = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Insira o numero");
            vetor[i] = double.Parse(Console.ReadLine());

        }

        escolheMaior();
        escolheMenor();
 //       imprime();


        //maior
        double escolheMaior()
        {
            double maior = vetor[0];

            for (int i = 0; i < 5; i++)
            {
                if (maior < vetor[i])
                {
                    maior = vetor[i];
                }
            }
            Console.WriteLine("Maior numero: " + maior );
            return maior;
        }


        //menor
        double escolheMenor()
        {
            double menor = vetor[0];

            for (int i = 0; i < 5; i++)
            {
                if (menor > vetor[i])
                {
                    menor = vetor[i];
                }
            }
            Console.WriteLine("Menor numero: " + menor);
            return menor;
        }

  /*
        void imprime()
        {
            Console.WriteLine("Maior numero: " + maior + ", e menor : " + menor);
        }
*/

    }
}
