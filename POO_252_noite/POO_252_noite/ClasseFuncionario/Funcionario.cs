using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseFuncionario // pasta
{
    public class Funcionario
    {
        // declaração de atributos
        public int codigo;
        public string nome;
        public double salario;
        // declaração de métodos
        public void MostrarAtributos(){
            Console.WriteLine("codigo: " + codigo + "\tNome: " + nome + "\tSalario: " + salario);
        }
        public void CalcularSalario(double porcentagem){
            salario = salario + (salario * porcentagem);
        }
    }
}