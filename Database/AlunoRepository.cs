    public class AlunoRepository : IAlunoRepository
    {

        List<Aluno> alunos = new List<Aluno>();

        public AlunoRepository()
        {
            alunos.Add(new Aluno {Id = 1, Nome = "Raphael", Matricula = "11110359", DataNascimento = "08/08/1991", Ativo = true });
            alunos.Add(new Aluno {Id = 1, Nome = "Guilherme", Matricula = "11110817", DataNascimento = "12/10/1989", Ativo = true });
            alunos.Add(new Aluno {Id = 1, Nome = "Luiz", Matricula = "11124501", DataNascimento = "01/08/1999", Ativo = true });
        }

        public void CadastrarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

    }