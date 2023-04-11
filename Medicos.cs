using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes
{
    public class Medico : Pessoa
    {
        public string Especialidade { get; set; }
        public int Id { get; set; }

        public Medico(string nome, int idade, string telefone, string especialidade, int id) : base(nome, idade, telefone)
        {
            Especialidade = especialidade;
            Id = id;
        }

        public override void MostrarDados()
        {
            Console.WriteLine("Médico:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Telefone: {telefone}");
        }
        public void MostrarDados(bool detalhado)    //Sobrecarga de método com parâmetros
        {
            Console.WriteLine("Médico:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Telefone: {telefone}");
            if (detalhado)
            {
                Console.WriteLine($"Especialidade: {Especialidade}");
            }
        }




    }
}