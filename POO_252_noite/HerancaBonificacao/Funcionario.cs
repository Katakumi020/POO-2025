using System;
using HerancaBonificacao;

namespace HerancaBonificacao
{
    public class Funcionario
    {
        protected int Codigo { get; set; }
        protected string Nome { get; set; }
        protected double Salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }

        public virtual double CalcularBonificacao()
        {
            return Salario * 0.10; // 10% padrão
        }

        public virtual string MostrarDados()
        {
            return $"Código: {Codigo} | Nome: {Nome} | Salário: {Salario:C}";
        }

        public string GetNome()
        {
            return Nome;
        }
    }
}