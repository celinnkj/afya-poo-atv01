using System;

class Conta
{
    private readonly int numero;
    private string titular;
    private double saldo;
    private double limite;

    public double SaldoTotal => saldo + limite;

    public string StatusConta => saldo < 0 ? "Negativo" : "Positivo";

    public Conta(int numero, string titular)
    {
        this.numero = numero;
        this.titular = titular;
        this.saldo = 0;
        this.limite = 500;
    }

    public bool Depositar(double valor)
    {
        if (valor <= 0) return false;

        saldo += valor;
        return true;
    }

    public bool Sacar(double valor)
    {
        if (valor <= SaldoTotal)
        {
            saldo -= valor;
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return $"Conta: {numero} | Titular: {titular} | Saldo: {saldo} | Limite: {limite}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Conta conta = new Conta(123, "Marcelo");

        conta.Depositar(200);
        conta.Sacar(600); // usa limite

        Console.WriteLine(conta);
        Console.WriteLine("Status: " + conta.StatusConta);
    }
}