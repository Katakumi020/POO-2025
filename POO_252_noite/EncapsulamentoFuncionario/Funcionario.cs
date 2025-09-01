using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario // pasta
{
    public class Funcionario
    {
        // declaração de atributos
        private int codigo;
        private string nome;
        private double salario;






        // declaração de métodos
        public void MostrarAtributos(){
            Console.WriteLine("codigo: " + codigo + "\tNome: " + nome + "\tSalario: " + salario);
        }
        public void CalcularSalario(double porcentagem){
            salario = salario + (salario * porcentagem);
        }
    }
}