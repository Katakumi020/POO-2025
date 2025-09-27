using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoEncapsulamentoEstudante // pasta
{
    public class Estudante
    {
        // declaração de atributos
private string nome;
    private double nota;
    public string Nome
    {
        get { return nome.ToUpper(); }
        set { nome = value; }
    }
    public double Nota
    {
        get { return nota; }
        set
        {
            if (value >= 0 && value <= 10)
                nota = value;
            else
                nota = 0;
        }
    }
    public void InformacoesAlunos()
    {
        Console.WriteLine($"Nome: {Nome}, Nota: {Nota}");
    }
    public bool EstaAprovado()
        {
            return Nota >= 6;
        }

    public void Aprovacao()
        {
            Console.WriteLine("Status: " + (EstaAprovado() ? "Aprovado" : "Reprovado"));
        }
    }
}