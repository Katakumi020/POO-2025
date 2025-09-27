using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoConstrutorAluno // pasta
{
    public class Aluno
    {
        // declaração de atributos
        public long Ra { get; private set; }
        public string Nome { get; private set; }
        private static long Contador;
        private const string PrefixoRa = "1570482"; 
        // Construtor sem parâmetro
        public Aluno()
        {
            Contador++;
            Ra = GerarRa();
            Nome = "Sem Nome";
        }

        // Construtor com parâmetro nome
        public Aluno(string nome)
        {
            Contador++;
            Ra = GerarRa();
            Nome = nome;
        }
    private long GerarRa() // eu quis criar isso para poder ter um exemplo igual o seu!
    {
        string RaCompleto = PrefixoRa + Contador.ToString("D4");
        return long.Parse(RaCompleto);
    }

    public void MostrarAtributos()
        {
            Console.WriteLine($"RA: {Ra} - Nome: {Nome}");
        }
    }
}