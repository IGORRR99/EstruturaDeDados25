using System;

class Program
{
    static void Main()
    {
        string[] nomes = { "Bacate", "Pinha", "Lorango", "Ova", "Cerola" };

        BubbleSort(nomes);

        Console.WriteLine("Vetor ordenado:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }

    static void BubbleSort(string[] vetor)
    {
        int n = vetor.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                // Usando CompareTo para comparar strings alfabeticamente
                if (vetor[j].CompareTo(vetor[j + 1]) > 0)
                {
                    // Troca
                    string temp = vetor[j];
                    vetor[j] = vetor[j + 1];
                    vetor[j + 1] = temp;
                }
            }
        }
    }
    
}

