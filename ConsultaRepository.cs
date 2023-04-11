using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace associacoes
{
    public class ConsultaRepository
    {
        public static List<Consulta> consultas = new List<Consulta>();

        public void Adicionar(Consulta consulta)
        {
            consultas.Add(consulta);
        }

        public List<Consulta> ListarConsulta()
        {
            return consultas;
        }

        public void AtualizarConsulta(Consulta consulta)
        {
            var consultaExistente = consultas.FirstOrDefault(c => c.idConsulta == consulta.idConsulta);
            if (consultaExistente != null)
            {
                consultaExistente.medico = consulta.medico;
                consultaExistente.paciente = consulta.paciente;
                consultaExistente.dataHora = consulta.dataHora;
            }
        }

        public Consulta ListarConsultasPorId(int id)
        {
            return consultas.FirstOrDefault(c => c.idConsulta == id);
        }

        
        public void RemoverConsultas(int id){
            var consultaExistente = consultas.FirstOrDefault(c => c.idConsulta == id);
            if (consultaExistente != null){
                consultas.Remove(consultaExistente);
            }
        }
    }
}