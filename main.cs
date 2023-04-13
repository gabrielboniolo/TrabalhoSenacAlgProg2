using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a quantidade de elementos do vetor: ");
        int n = int.Parse(Console.ReadLine());

        int[] vetor = new int[n];

        Console.WriteLine("Digite os elementos do vetor:");

        for (int i = 0; i < n; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int maiorDiferenca = CalcularMaiorDiferenca(vetor);
        Console.WriteLine("Maior diferença entre dois elementos distintos do vetor: " + maiorDiferenca);

        bool estaOrdenado = VerificarSeEstaOrdenado(vetor);
        Console.WriteLine("O vetor está em ordem crescente? " + estaOrdenado);
    }

    static int CalcularMaiorDiferenca(int[] vetor)
    {
        int maiorDiferenca = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            for (int j = i + 1; j < vetor.Length; j++)
            {
                int diferenca = Math.Abs(vetor[i] - vetor[j]);

                if (diferenca > maiorDiferenca)
                {
                    maiorDiferenca = diferenca;
                }
            }
        }

        return maiorDiferenca;
    }

    static bool VerificarSeEstaOrdenado(int[] vetor)
    {
        for (int i = 0; i < vetor.Length - 1; i++)
        {
            if (vetor[i] > vetor[i + 1])
            {
                return false;
            }
        }

        return true;
    }
}