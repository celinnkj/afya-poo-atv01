using System;

class Personagem
{
    private string nome;
    private string classe;
    private int nivel;
    private double vidaAtual;
    private double vidaMaxima;

    public Personagem(string nome, string classe)
    {
        this.nome = nome;
        this.classe = classe;
        this.nivel = 1;

        if (classe == "Guerreiro")
            vidaMaxima = 150;
        else
            vidaMaxima = 80;

        vidaAtual = vidaMaxima;
    }

    public void ReceberDano(double pontos)
    {
        vidaAtual -= pontos;
        if (vidaAtual < 0)
            vidaAtual = 0;
    }

    public void Curar(double pontos)
    {
        if (vidaAtual == 0)
        {
            Console.WriteLine("Personagem morto!");
            return;
        }

        vidaAtual += pontos;
        if (vidaAtual > vidaMaxima)
            vidaAtual = vidaMaxima;
    }

    public void SubirNivel()
    {
        if (vidaAtual == 0)
        {
            Console.WriteLine("Personagem morto!");
            return;
        }

        nivel++;
        vidaMaxima *= 1.10;
        vidaAtual = vidaMaxima;
    }

    public override string ToString()
    {
        return $"{nome} ({classe}) - Lvl {nivel} - HP: {vidaAtual}/{vidaMaxima}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Personagem p = new Personagem("Marcelo", "Guerreiro");

        Console.WriteLine(p);

        p.ReceberDano(50);
        Console.WriteLine(p);

        p.SubirNivel();
        Console.WriteLine(p);

        p.ReceberDano(200);
        Console.WriteLine(p);

        p.Curar(50); // não funciona (morto)
        p.SubirNivel(); // não funciona (morto)
    }
}
