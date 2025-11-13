using System;

namespace Algoritmo_de_Busca
{
    public class Program
    {
        static void Main()
        {
            string[] vetor = { "9", "99", "999", "9999", "99999", "999999", "9999999", "99999999", "999999999", "9999999999" };

            Console.Write("Digite o número que deseja buscar: ");
            string busca = Console.ReadLine();

            bool encontrado = false;

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i].Equals(busca, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"'{busca}' encontrado na posição {i} do vetor.");
                    encontrado = true;
                    break;
                }
            }
            
            if (!encontrado)
            {
                Console.WriteLine("Valor não encontrado no vetor.");
            }

            static void Pause()
                {  
                    Pause();
                }
        }
    }
}