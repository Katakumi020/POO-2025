using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAbstrata
{
    public class Endereco
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }

        public Endereco(string rua, int numero, string cidade)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
        }
    }
}