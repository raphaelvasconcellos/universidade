using Universidade.Interface;
namespace Universidade.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }


        public void CadastrarAluno(Aluno aluno)
        {
            if (aluno == null)
            {
                throw new ArgumentNullException(nameof(aluno));
            }
            _alunoRepository.CadastrarAluno(aluno);
        }

        public void AtualizarAluno(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public void LerAluno(Aluno aluno)
        {
            throw new NotImplementedException();
        }

        public void RemoverAluno(Aluno aluno)
        {
            throw new NotImplementedException();
        }
    }
}