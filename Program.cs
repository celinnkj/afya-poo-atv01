using System;

class Lampada
{
    private string marca;
    private readonly string tecnologia;
    private bool ligada;
    private int brilho;

    public Lampada(string marca, string tecnologia)
    {
        this.marca = marca;
        this.tecnologia = tecnologia;
        this.ligada = false;
        this.brilho = 100;
    }

    public void Alternar()
    {
        ligada = !ligada;
    }

    public void AjustarBrilho(int novoBrilho)
    {
        if (!ligada)
        {
            Console.WriteLine("A lâmpada precisa estar ligada.");
            return;
        }

        if (novoBrilho >= 0 && novoBrilho <= 100)
        {
            brilho = novoBrilho;
        }
    }

    public override string ToString()
    {
        return $"Marca: {marca} | Tecnologia: {tecnologia} | Ligada: {ligada} | Brilho: {brilho}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Lampada lampada = new Lampada("Philips", "LED");

        Console.WriteLine(lampada);

        lampada.Alternar();
        lampada.AjustarBrilho(50);

        Console.WriteLine(lampada);
    }
}
