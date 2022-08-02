using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudante aluno;
            aluno = new Estudante("8a", "Diogo", "7428746sspgo", DateTime.Parse("17/01/1990"));
            aluno.SetApresentar();

            Console.ReadLine();
        }
    }
}
