using System;
using System.Collections.Generic;

class Program
{
    class Pacote
    {
        public string Encomenda;
        public string Descricao;
        public Pacote(string e, string d) { Encomenda = e; Descricao = d; }
    }

    static void Main()
    {
        var dados = new Dictionary<string, Pacote>();
        bool rodando = true;

        while (rodando)
        {
            Console.Write("\nDigite o código de rastreio (ou deixe vazio para sair): ");
            string r = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(r))
            {
                rodando = false;
                continue;
            }

            if (dados.ContainsKey(r))
            {
                Console.WriteLine("\n⚠ Este código já existe. Aqui estão os dados:");
                Console.WriteLine($"Encomenda: {dados[r].Encomenda}");
                Console.WriteLine($"Descrição: {dados[r].Descricao}");
            }
            else
            {
                Console.Write("Código da encomenda: ");
                string e = Console.ReadLine();

                Console.Write("Descrição: ");
                string d = Console.ReadLine();

                dados[r] = new Pacote(e, d);

                Console.WriteLine("\n✔ Cadastro realizado!");
            }

            Console.Write("\nDeseja buscar por encomenda? (s/n): ");
            string resp = Console.ReadLine().ToLower();

            if (resp == "s")
            {
                Console.Write("Informe o código da encomenda: ");
                string buscar = Console.ReadLine();

                bool encontrou = false;

                foreach (var item in dados)
                {
                    if (!encontrou && item.Value.Encomenda == buscar)
                    {
                        Console.WriteLine("\n📦 ENCONTRADO:");
                        Console.WriteLine($"Rastreio: {item.Key}");
                        Console.WriteLine($"Encomenda: {item.Value.Encomenda}");
                        Console.WriteLine($"Descrição: {item.Value.Descricao}");
                        encontrou = true;
                    }
                }

                if (!encontrou)
                    Console.WriteLine("\n❌ Nenhum pacote encontrado para essa encomenda.");
            }
        }

        Console.WriteLine("\nPrograma encerrado.");
    }
}