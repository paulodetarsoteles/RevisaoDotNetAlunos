using RevisaoBasica;

List<Aluno> alunos = new List<Aluno>();
string opcao = Opcoes.MenuInicial();

while (opcao.ToUpper() != "X")
{
    switch (opcao)
    {
        case "1": //TODO Inserir aluno
            Aluno aluno = new Aluno();
            Opcoes.Inserir(aluno);
            alunos.Add(aluno);
            break;

        case "2": //TODO Listar alunos
            foreach (Aluno a in alunos)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            break;

        case "3": //TODO Calcular média geral
            int qtde = alunos.Count();
            decimal total = 0;
            foreach (Aluno a in alunos) total += a.Nota;
            Console.WriteLine("A Média da turma é: " + total / qtde);
            Console.WriteLine();
            break;

        case "4": //TODO Listar ordenado por nome
            alunos.Sort(Opcoes.OrdenarPorNome);
            foreach (Aluno a in alunos)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            break;

        case "5": //TODO Listar ordenado por nota
            alunos.Sort(Opcoes.OrdenarPorNota); 
            foreach (Aluno a in alunos)
            {
                Console.WriteLine(a);
            }
            break; 

        default:
            throw new Exception("Opção Inválida!");
    }

    opcao = Opcoes.MenuInicial();
}