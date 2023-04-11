using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes
{
    public class PacienteRepository
    {
        public static List<Paciente> pacientes = new List<Paciente>();

        public void AdicionarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }

        public void AtualizarPaciente(Paciente paciente)
        {
            var pacienteExistente = pacientes.FirstOrDefault(p => p.Id == paciente.Id);
            if (pacienteExistente != null)
            {
                pacienteExistente.nome = paciente.nome;
                pacienteExistente.idade = paciente.idade;
                pacienteExistente.telefone = paciente.telefone;
                pacienteExistente.Endereco = paciente.Endereco;
            }
        }

        public void RemoverPaciente(int id)
        {
            var pacienteExistente = pacientes.FirstOrDefault(p => p.Id == id);
            if (pacienteExistente != null)
            {
                pacientes.Remove(pacienteExistente);
            }
        }

        public List<Paciente> ListarPacientes()
        {
            return pacientes;
        }

        public Paciente BuscarPacientePorId(int id)
        {
            return pacientes.FirstOrDefault(p => p.Id == id);
        }
    }
}