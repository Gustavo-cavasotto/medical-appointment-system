using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes
{
    public class Paciente : Pessoa
    {
        public string Endereco { get; set; }
        public int Id { get; set; }

        public Paciente(string nome, int idade, string telefone, string endereco, int id) : base(nome, idade, telefone)
        {
            Endereco = endereco;
            Id = id;
        }

        public override void MostrarDados()
        {
            Console.WriteLine("Paciente:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Telefone: {telefone}");
            Console.WriteLine($"Endereço: {Endereco}");
        }
    }
}