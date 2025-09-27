using System;

public class Comprador
{
    public string Nome { get; set; }
    private double verba;
    public Comprador(string nome, double verbaInicial)
    {
        Nome = nome;
        Verba = verbaInicial;
    }
    public double Verba
    {
        get { return verba; }
        private set { verba = value >= 0 ? value : 0; }
    }
    public void SubtrairVerba(double valor)
    {
        if (valor <= verba)
            verba -= valor;
        else
            Console.WriteLine("Verba insuficiente para esta compra.");
    }
}