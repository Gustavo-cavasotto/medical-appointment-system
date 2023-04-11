using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes
{
    public class Consulta
    {
        public int idConsulta { get; set; }
        public Medico medico { get; set; }
        public Paciente paciente { get; set; }
        public DateTime dataHora { get; set; }
        

        public Consulta(int id, Medico medico, Paciente paciente, DateTime dataHora)
        {
            this.idConsulta = id;
            this.medico = medico;
            this.paciente = paciente;
            this.dataHora = dataHora;
        }
        public string ExibirPaciente()
        {
            return "Consulta: " + this.idConsulta + " Médico: " + this.medico.nome + " Paciente: " + this.paciente.nome;
        }

    }
}