using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    // Pilares da Programação orientada a objetos
    // Herança --> abstract: a classe não pode ser instanciada só herdada
    public abstract class Pessoa
    {

        // Encapsulamento --> public, protected, private, etc... proteção e visibilidade da classe
        public string Nome { get; protected set; }
        public string Documento { get; protected set; }
        public DateTime DataNascimento { get; protected set; }

        public Pessoa(string nome, string documento, DateTime dataNascimento)
        {
            Nome = nome;
            Documento = documento;
            DataNascimento = dataNascimento;

        }
        // Polimorfismo --> classes filhas acrescentar mais comportamentos, virtual: permite que o elemento seja modificado

        public virtual void SetApresentar()
        {
            Console.WriteLine($"Olá, meu  nome é {Nome}, Documento:{Documento}, Data de Nascimento: {DataNascimento}");
        }



    }
}
