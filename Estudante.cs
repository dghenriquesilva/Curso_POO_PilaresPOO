using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    public class Estudante : Pessoa
    {
        public string Turma { get; private set; }
        public List<int> Notas { get; set; }

        // base --> usando a herança
        public Estudante(string turma, string nome, string documento, DateTime dataNascimento)
            : base(nome, documento, dataNascimento)
        {
            Turma = turma;
            Notas = new List<int> { 10, 6, 3, 8 };

        }
        // usando o polimorfismo
        public override void SetApresentar()
        {
            base.SetApresentar();
            var media = Notas.Average();
            Console.WriteLine($"Sou um estudante da turma: {Turma}, Média da nota: {media}");
        }


    }
}


