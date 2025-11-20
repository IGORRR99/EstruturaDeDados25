// os dicionarios funcionam da msm forma q as tabelas hashs
// mas é possivel add um tipo de dado que será utilizado
// para armazenar tanto a chave quanto o valor.
// diferente da tabela hash que utiliza apenas de string

// criando um dicionario vazio
Dictionary<string, int> dice0 =
    new Dictionary<string, int>();

// criando um dicionario com valores
Dictionary<string, int> dic =
    new Dictionary<string, int>
    {
        { "Chave 1", 100 },
        { "Chave 2", 200 },
    };

// Podemos add informando diretamente a chave
dic["Chave 3"] = 300;
dic.Add("Chave 4", 400);

// para procurar
if (dic.ContainsKey("Chave 4"))
{
    Console.WriteLine($"Encontrado Chave 4,c{dic["Chave 4"]}");
}

// Percorrendo o dicionario
foreach (KeyValuePair<string, int> kv in dic)
{
    Console.WriteLine($"Chave: {kv.Key} - Valor: {kv.Value}");
}

