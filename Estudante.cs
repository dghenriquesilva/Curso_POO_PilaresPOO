using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp5.Entities.Enums;
namespace ConsoleApp5
{
    public class Estudante : Pessoa
    {
        public string Turma { get; private set; }
        public List<int> Notas { get; set; }
        public Status StatusEstudante { get; set; }
        public double Media { get; private set; }
        // base --> usando a herança
        public Estudante(string turma, string nome, string documento, DateTime dataNascimento)
            : base(nome, documento, dataNascimento)
        {
            Turma = turma;
            Notas = new List<int> { 10, 6, 3, 1 };

        }
        // usando o polimorfismo
        public override void SetApresentar()
        {
            base.SetApresentar();
            var media = Notas.Average();
            Media = 6;
          if (media >= Media)
            {
                StatusEstudante = Status.Aprovado;
            }
            else if(media >=5 && media < Media)
            {
                StatusEstudante = Status.Recuperacao;
            }
            else
            {
                StatusEstudante = Status.Reprovado;
            }

            Console.WriteLine($"Sou um estudante da turma: {Turma}, Média da nota: {media} e a situação é: {StatusEstudante.ToString()}");
        }


    }
}


