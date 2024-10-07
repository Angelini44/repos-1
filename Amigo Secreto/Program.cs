using System.Security.Cryptography;
using System.Xml;

List<string> ListaDeAmigos = new List<string>();

Console.WriteLine("Digite o Numero de Amigos que vao participar do sorteio: ");
string n = Console.ReadLine();
int Numero = int.Parse(n);

Console.WriteLine("Digite os nomes: ");
for (int i = 0; i < Numero; i++)
{
    string amigo = Console.ReadLine();
    ListaDeAmigos.Add(amigo);
}



Sorteio(Numero);


void Sorteio(int tamanho)
{

    Random random = new Random();
    List<int> ListadeNumerosAleatorios = new List<int>();


    int k = 0;
    while (ListadeNumerosAleatorios.Count < tamanho)
    {
        int numeroAleatorio = random.Next(0, tamanho);
        if (ListadeNumerosAleatorios.Contains(numeroAleatorio) || ListaDeAmigos[k] == ListaDeAmigos[numeroAleatorio])
        {
            continue;
        }
        else
        {
            ListadeNumerosAleatorios.Add(numeroAleatorio);
            k++;
        }
    }

     
    //for (int i = 0; i < ListadeNumerosAleatorios.Count; i++)
    //{
    //    Console.WriteLine(ListadeNumerosAleatorios[i]);
    //}

    for (int i = 0; i < tamanho; i++)
    {
        Console.WriteLine($"{ListaDeAmigos[i]} --> {ListaDeAmigos[ListadeNumerosAleatorios[i]]}");
    }

}
