using Modelo.Application.Interfaces;
using Modelo.Domain;
using Modelo.Infra.Repositorio.Interfaces;

namespace Modelo.Application
{
    public class AlunoApplication : IAlunoApplication
    {
        private readonly IAlunoRepositorio _alunoRepositorio;

        public AlunoApplication(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }

        public Aluno BuscarAluno(int id)
        {
            return _alunoRepositorio.BuscarId(id);
        }

        public string InserirAluno(Aluno aluno)
        {
            string mensagem = ValidaAluno(aluno);

            if (mensagem == "")
            {
                _alunoRepositorio.InserirAluno(aluno);
                mensagem = "Aluno inserido com sucesso!";  
            }
            return mensagem;
        }

        public void AlterarAluno(Aluno aluno)
        {
            _alunoRepositorio.AlterarAluno(aluno);
        }
        public void AlterarTotalAluno(Aluno aluno)
        {
            _alunoRepositorio.AlterarTotalAluno(aluno);
        }

        public void ExcluirAluno(int id)
        {
            _alunoRepositorio.ExcluirAluno(id);
        }

        private string ValidaAluno(Aluno aluno)
        {
            string mensagem = "";
            if (aluno == null)
                mensagem = "Aluno não pode ser nulo";

            if (!aluno.Nome.Any())
                mensagem = "Não é possivel inserir aluno sem nome";
                
            if(aluno.Nome.Length > 50)
                mensagem = "O nome do aluno deve ter no máximo 50 caracteres";

            if (aluno.Cep.Length > 14)
                mensagem = "O cep deve possuir apenas 14 caracteres";

            if (aluno.Idade < 0)
                mensagem = "Informe uma idade válida!";

            if (aluno.Idade > 120)
                mensagem = "Idade não pode ser maior que 120 anos";

            if (aluno.Idade == 0)
                mensagem = "Idade não pode ser zero";

            return mensagem;
        }
    }
}
