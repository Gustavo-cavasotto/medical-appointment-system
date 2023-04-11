using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes
{
    public class MedicoRepository
    {
        public static List<Medico> medicos = new List<Medico>();

        public void AdicionarMedico(Medico medico)
        {
            medicos.Add(medico);
        }

        public void AtualizarMedico(Medico medico)
        {
            var medicoExistente = medicos.FirstOrDefault(m => m.Id == medico.Id);
            if (medicoExistente != null)
            {
                medicoExistente.nome = medico.nome;
                medicoExistente.idade = medico.idade;
                medicoExistente.telefone = medico.telefone;
                medicoExistente.Especialidade = medico.Especialidade;
            }
        }

        public void RemoverMedico(int id)
        {
            var medicoExistente = medicos.FirstOrDefault(m => m.Id == id);
            if (medicoExistente != null)
            {
                medicos.Remove(medicoExistente);
            }
        }

        public List<Medico> ListarMedicos()
        {
            return medicos;
        }

        public Medico BuscarMedicoPorId(int id)
        {
            return medicos.FirstOrDefault(m => m.Id == id);
        }
    
    }
}