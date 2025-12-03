using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    public class Departamento
    {
        public string Nome { get; set; }
        public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();

        public Departamento(string nome)
        {
            Nome = nome;
        }

        public void Admitir(Funcionario f)
        {
            Funcionarios.Add(f);
        }

        public bool Demitir(int codigo)
        {
            return Funcionarios.RemoveAll(f => f.Codigo == codigo) > 0;
        }

        public void ListarFuncionarios(int diasUteis)
        {
            foreach (var f in Funcionarios)
            {
                Console.WriteLine($"Nome: {f.Nome} | Salário: {f.CalcularSalario(diasUteis)}");
            }
        }

        public double CalcularCustoFolha(int diasUteis)
        {
            double total = 0;
            foreach (var f in Funcionarios)
            {
                total += f.CalcularSalario(diasUteis);
            }
            return total;
        }
    }
}