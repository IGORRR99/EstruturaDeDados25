using System.Collections;



Hashtable ht = new Hashtable()
{
    { "Igorr", "9" },
    { "Igor", "12" }
};

Console.WriteLine("Teste");

// forma de add outro par (key e valor)

ht["Igor Lima"] = "789";
ht.Add("Igor Igor", "666");
if (ht.Count > 0)
{
    // Percorrer os pares armazenas
    foreach (DictionaryEntry entry in ht)
    {
        Console.WriteLine($"Chave: {entry.Key}, Valor: {entry.Value}");
    }
}
else
{
    Console.WriteLine("Tabela Hash Vazia");
}

// ao add uma chave repetida a hashtable o programa crasha e interrope a exec
// para evitar isso, usamos da clausula (sentença) try {} catch

try
{
    ht.Add("Igor", "99");
}
catch (ArgumentException ex2)
{
    Console.WriteLine("Não é possível add chaves iguais.");
    //Console.WriteLine(ex2.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Erro Desconhecido");
}
finally
{
    Console.WriteLine("Agora vai funcionar");
}

// agora o usuario informa

Console.WriteLine("Informe a chave: ");
string key = Console.ReadLine();
Console.WriteLine("Informe o valor: ");
string value = Console.ReadLine();

try
{
    ht.Add(key, value);
    Console.WriteLine("Par chave-valor adicionado!");
}
catch
{
    Console.WriteLine("Ops! Chave Ja Existente.");
}

// agora faremos uma busca na tabela Hash

Console.WriteLine("O que você precisa?");
string search = Console.ReadLine();

if (ht.Contains(search))
{
    Console.WriteLine($"Encontrado! {search}, {ht[search]}");
}
else
{
    Console.WriteLine("Non Ecxiste!");
}
