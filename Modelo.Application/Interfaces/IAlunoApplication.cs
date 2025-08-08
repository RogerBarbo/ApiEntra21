using Modelo.Domain;

namespace Modelo.Application.Interfaces
{
    public interface IAlunoApplication
    {
        Aluno BuscarAluno(int id);

        string InserirAluno(Aluno aluno);

        void AlterarAluno(Aluno aluno);

        void AlterarTotalAluno(Aluno aluno);

        void ExcluirAluno(int id);
    }
}