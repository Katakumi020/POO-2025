using System;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private string? titular;
        private double saldo;
        private int numero;  // Declarando o campo privado numero

        public int Numero
        {//numero maiusculo é a propriedade, propriedade é a representação dos metodos de encapsulamento get e set
            get
            {
                return numero;
            }
            set //numero minusculo é o atributo
            {
                numero = value;
            }
        }

        public string? Titular//propriedade
        {
            get
            {
                return titular;//atributo
            }
            set
            {
                titular = value;
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero + "\tTitular: " + titular + "\tSaldo: " + saldo);
        }

        public void Sacar(double valorSaque)
        {
            if (valorSaque > 0 && valorSaque <= saldo)
            {
                saldo -= valorSaque;
                Console.WriteLine($"Saque de {valorSaque} realizado com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido para saque.");
            }
        }
    }
}