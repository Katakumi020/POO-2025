using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double SalarioBase { get; set; }
        public Endereco Endereco { get; set; }

        public List<Dependente> Dependentes { get; private set; } = new List<Dependente>();

        public Funcionario(int codigo, string nome, double salarioBase)
        {
            Codigo = codigo;
            Nome = nome;
            SalarioBase = salarioBase;
        }

        public abstract double CalcularSalario(int diasUteis);

        public void AdicionarDependente(Dependente d)
        {
            Dependentes.Add(d);
        }

        public bool RemoverDependente(int codigo)
        {
            return Dependentes.RemoveAll(d => d.Codigo == codigo) > 0;
        }

        public int CalcularTotalDependentes()
        {
            return Dependentes.Count;
        }

        public void ListarDependentes()
        {
            foreach (var d in Dependentes)
            {
                Console.WriteLine($"Dependente: {d.Nome}, Idade: {d.Idade}");
            }
        }
    }
}