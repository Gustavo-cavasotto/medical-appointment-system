using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes
{
    public abstract class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string telefone { get; set; } 

        public Pessoa(string nome, int idade, string telefone){
            this.nome = nome;
            this.idade = idade;
            this.telefone = telefone;
        }
        
        public abstract void MostrarDados(); //Método abstrato que deve ser implementado nas classes que herdam de Pessoa
    }
}