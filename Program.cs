using System;

class Cofre
{
    private string dono;
    private string senha;
    private bool estaAberto;
    private int tentativas;

    public bool EstaAberto => estaAberto;

    public Cofre(string dono, string senha)
    {
        this.dono = dono;
        this.senha = senha;
        this.estaAberto = false;
        this.tentativas = 0;
    }

    public void Abrir(string senhaInformada)
    {
        if (tentativas >= 3)
        {
            Console.WriteLine("Cofre Bloqueado!");
            return;
        }

        if (senhaInformada == senha)
        {
            estaAberto = true;
            tentativas = 0;
            Console.WriteLine("Cofre aberto!");
        }
        else
        {
            tentativas++;
            Console.WriteLine("Senha incorreta!");
        }
    }

    public void Fechar()
    {
        estaAberto = false;
    }

    public void AlterarSenha(string senhaAntiga, string novaSenha)
    {
        if (!estaAberto)
        {
            Console.WriteLine("O cofre precisa estar aberto.");
            return;
        }

        if (senhaAntiga == senha)
        {
            senha = novaSenha;
            Console.WriteLine("Senha alterada!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cofre cofre = new Cofre("Marcelo", "1234");

        cofre.Abrir("1111");
        cofre.Abrir("2222");
        cofre.Abrir("3333");
        cofre.Abrir("1234"); // deve bloquear antes

        cofre.Abrir("1234");

        cofre.Fechar();
    }
}
