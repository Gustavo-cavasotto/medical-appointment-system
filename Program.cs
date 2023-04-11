using associacoes;



Console.WriteLine("Bem-vindo ao sistema de consultas!");

// instanciando os repositórios
var medicoRepository = new MedicoRepository();
var pacienteRepository = new PacienteRepository();
var consultaRepository = new ConsultaRepository();

while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Cadastrar Médico");
    Console.WriteLine("2. Listar Médicos");
    Console.WriteLine("3. Atualizar Médico");
    Console.WriteLine("4. Excluir Médico");
    Console.WriteLine("5. Cadastrar Paciente");
    Console.WriteLine("6. Listar Pacientes");
    Console.WriteLine("7. Atualizar Paciente");
    Console.WriteLine("8. Excluir Paciente");
    Console.WriteLine("9. Cadastrar Consulta");
    Console.WriteLine("10. Listar Consultas");
    Console.WriteLine("11. Atualizar Consulta");
    Console.WriteLine("12. Excluir Consulta");
    Console.WriteLine("0. Sair");

    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            // cadastro de médico
            Console.WriteLine("Digite o id do médico:");
            var idMedico = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do médico:");
            var nomeMedico = Console.ReadLine();
            Console.WriteLine("Digite a idade do médico:");
            var idadeMedico = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o telefone do médico:");
            var telefoneMedico = Console.ReadLine();
            Console.WriteLine("Digite a especialidade do médico:");
            var especialidadeMedico = Console.ReadLine();

            var novoMedico = new Medico(nomeMedico, idadeMedico, telefoneMedico, especialidadeMedico, idMedico);
            medicoRepository.AdicionarMedico(novoMedico);

            Console.WriteLine("Médico cadastrado com sucesso!");
            break;
        case "2":
            // listagem de médicos
            Console.WriteLine("Listando médicos:");

            foreach (var medico in medicoRepository.ListarMedicos())
            {
                Console.WriteLine($"ID: {medico.Id} | Nome: {medico.nome} | Idade: {medico.idade} | Telefone: {medico.telefone} | Especialidade: {medico.Especialidade}");
            }

            break;
        case "3":
            // atualização de médico
            Console.WriteLine("Digite o ID do médico que deseja atualizar:");
            var idmedico = Convert.ToInt32(Console.ReadLine());

            var medicoAtualizar = medicoRepository.BuscarMedicoPorId(idmedico);

            if (medicoAtualizar != null)
            {
                Console.WriteLine("Digite o novo nome do médico:");
                medicoAtualizar.nome = Console.ReadLine();
                Console.WriteLine("Digite a nova idade do médico:");
                medicoAtualizar.idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o novo telefone do médico:");
                medicoAtualizar.telefone = Console.ReadLine();
                Console.WriteLine("Digite a nova especialidade do médico:");
                medicoAtualizar.Especialidade = Console.ReadLine();

                medicoRepository.AtualizarMedico(medicoAtualizar);

                Console.WriteLine("Médico atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Médico não encontrado.");
            }
            break;
        case "4":
            // exclusão de médico
            Console.WriteLine("Digite o ID do médico que deseja excluir: ");
            if (int.TryParse(Console.ReadLine(), out int idMedicoExcluir))
            {
                medicoRepository.RemoverMedico(idMedicoExcluir);
                Console.WriteLine("Médico removido com sucesso!");
            }
            else
            {
                Console.WriteLine("ID inválido!");
            }
            break;
        case "5":
            // cadastro de paciente
            Console.WriteLine("Digite o id do paciente:");
            var idPaciente = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do paciente:");
            var nomePaciente = Console.ReadLine();
            Console.WriteLine("Digite a idade do paciente:");
            var idadePaciente = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o telefone do paciente:");
            var telefonePaciente = Console.ReadLine();
            Console.WriteLine("Digite o endereço do paciente:");
            var enderecoPaciente = Console.ReadLine();

            var novoPaciente = new Paciente(nomePaciente.Trim( ), idadePaciente, telefonePaciente, enderecoPaciente, idPaciente);
            pacienteRepository.AdicionarPaciente(novoPaciente);

            Console.WriteLine("Paciente cadastrado com sucesso!");
            break;
        case "6":
            Console.WriteLine("Listando pacientes:");

            foreach (var paciente in pacienteRepository.ListarPacientes())
            {
                Console.WriteLine($"ID: {paciente.Id} | Nome: {paciente.nome} | Idade: {paciente.idade} | Telefone: {paciente.telefone} | Endereço: {paciente.Endereco}");
            }

            break;
        case "7":
            // atualização de paciente
            Console.WriteLine("Digite o ID do Paciente que deseja atualizar:");
            var idpaciente = Convert.ToInt32(Console.ReadLine());

            var pacienteAtualizar = pacienteRepository.BuscarPacientePorId(idpaciente);

            if (pacienteAtualizar != null)
            {
                Console.WriteLine("Digite o novo nome do paciente:");
                pacienteAtualizar.nome = Console.ReadLine();
                Console.WriteLine("Digite a nova idade do paciente:");
                pacienteAtualizar.idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o novo telefone do paciente:");
                pacienteAtualizar.telefone = Console.ReadLine();
                Console.WriteLine("Digite o novo endereco do paciente:");
                pacienteAtualizar.Endereco = Console.ReadLine();

                pacienteRepository.AtualizarPaciente(pacienteAtualizar);

                Console.WriteLine("Paciente atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Paciente não encontrado.");
            }
            break;
        
        case "8":
        // exclusão de paciente
            Console.WriteLine("Digite o ID do paciente que deseja excluir: ");
            if (int.TryParse(Console.ReadLine(), out int idPacienteExcluir))
            {
                pacienteRepository.RemoverPaciente(idPacienteExcluir);
                Console.WriteLine("Paciente removido com sucesso!");
            }
            else
            {
                Console.WriteLine("ID inválido!");
            }
            break;

        case "9":
            // cadastro de consulta
            Console.WriteLine("Digite o ID da consulta:");
            var idConsulta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ID do médico:");
            var idMedicoConsulta = int.Parse(Console.ReadLine());
            var medicoConsulta = medicoRepository.BuscarMedicoPorId(idMedicoConsulta);
            if (medicoConsulta == null)
            {
                Console.WriteLine("Médico não encontrado.");
                break;
            }

            Console.WriteLine("Digite o ID do paciente:");
            var idPacienteConsulta = int.Parse(Console.ReadLine());
            var pacienteConsulta = pacienteRepository.BuscarPacientePorId(idPacienteConsulta);
            if (pacienteConsulta == null)
            {
                Console.WriteLine("Paciente não encontrado.");
                break;
            }

            Console.WriteLine("Digite a data e hora da consulta (formato: dd/MM/yyyy HH:mm):");
            var dataHoraConsulta = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);

            var consulta = new Consulta(idConsulta, medicoConsulta, pacienteConsulta, dataHoraConsulta);
            consultaRepository.Adicionar(consulta);
            Console.WriteLine("Consulta cadastrada com sucesso!");
            break;

        case "10":
            //Listar consulta
            Console.WriteLine("Listando consultas:");

            foreach (var consultas in consultaRepository.ListarConsulta())
            {
                Console.WriteLine($"ID: {consultas.idConsulta} | Médico: {consultas.medico.nome} | Paciente: {consultas.paciente.nome} | Data e Hora: {consultas.dataHora}");
            }

            break;
        case "11":
            // atualização de consulta
            Console.WriteLine("Digite o ID da Consulta que deseja atualizar:");
            var idconsulta = Convert.ToInt32(Console.ReadLine());

            var consultaAtualizar = consultaRepository.ListarConsultasPorId(idconsulta);

            if (consultaAtualizar != null)
            {
                Console.WriteLine("Digite o ID do novo médico:");
                var idMedicoConsultaBuscar = int.Parse(Console.ReadLine());
                var novoMedicoConsulta = medicoRepository.BuscarMedicoPorId(idMedicoConsultaBuscar);
                if (novoMedicoConsulta == null)
                {
                    Console.WriteLine("Médico não encontrado.");
                }
                consultaAtualizar.medico = novoMedicoConsulta;

                Console.WriteLine("Digite o ID do novo paciente:");
                var idPacienteConsultaBuscar = int.Parse(Console.ReadLine());
                var novoPacienteConsulta = pacienteRepository.BuscarPacientePorId(idPacienteConsultaBuscar);
                if (novoPacienteConsulta == null)
                {
                    Console.WriteLine("Paciente não encontrado.");
                }
                consultaAtualizar.paciente = novoPacienteConsulta;

                Console.WriteLine("Digite a nova data da consulta (formato: dd/MM/yyyy HH:mm)");
                var novaData = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);
                consultaAtualizar.dataHora = novaData;


                consultaRepository.AtualizarConsulta(consultaAtualizar);

                Console.WriteLine("Consulta atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine("Consulta não encontrada.");
            }
            break;
        case "12":
            // exclusão de consulta
            Console.WriteLine("Digite o ID da consulta que deseja excluir: ");
            if (int.TryParse(Console.ReadLine(), out int idConsultaExcluir))
            {
                consultaRepository.RemoverConsultas(idConsultaExcluir);
                Console.WriteLine("Consulta removida com sucesso!");
            }
            else
            {
                Console.WriteLine("ID inválido!");
            }
            break;
        case "0":
            Environment.Exit(0);
            break;
    }
    

    
}





