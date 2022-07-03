namespace RevisaoBasica
{
    public struct Opcoes
    {
        public static string MenuInicial()
        {
            Console.WriteLine("- - - - - - - - - - - - ");
            Console.WriteLine("INFORME A OPÇÃO DESEJADA: ");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("4- Ordenar alunos por nome");
            Console.WriteLine("5- Ordenar alunos por nota");
            Console.WriteLine("X- Sair");
            Console.WriteLine("- - - - - - - - - - - - ");
            Console.WriteLine(" ");

            string opcao = Console.ReadLine();
            Console.WriteLine();

            return opcao;
        }

        public static void Inserir(Aluno aluno)
        {
            Console.Write("Informe o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite a nota do aluno: ");
            aluno.Nota = decimal.Parse(Console.ReadLine());
            aluno.ConceitoAluno();
        }

        public static int OrdenarPorNome(Aluno a1, Aluno a2)
        {
            return a1.Nome.ToUpper().CompareTo(a2.Nome.ToUpper());
        }

        public static int OrdenarPorNota (Aluno a1, Aluno a2)
        {
            return a1.Nota.CompareTo(a2.Nota); 
        }
    }
}