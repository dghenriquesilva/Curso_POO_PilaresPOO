using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    // Exemplo de herança
    public class Professor:Pessoa
    {
        // Propriedades
        public List<string> Materia { get; private set; }

        // Construtor
        public Professor(string nome, string documento, DateTime datanascimento, params string[] materia)
            : base(nome, documento, datanascimento)
        {
            foreach(string m in materia)
            {
                Materia.Add(m.ToString());
            }
        }
    }
}
