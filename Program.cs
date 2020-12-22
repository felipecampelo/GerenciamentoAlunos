using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = "";

            while (opcaoUsuario != "4")
            {
                opcaoUsuario = ObterOpcaoUsuario();

                switch(opcaoUsuario)
                {
                    case "1":
                        //TODO: Adicionar Aluno
                        Console.WriteLine("Informe o nome do aluno:");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal.");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        //TODO: Listar Alunos
                        foreach(var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {a.Nome} | Nota: {a.Nota}");
                            }
                        }
                        break;
                    case "3":
                        //TODO: Calcular média geral
                        decimal soma = 0;
                        int quantidade = 0;

                        foreach(var a in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                soma += a.Nota;
                                quantidade++;
                            }
                        }
                        decimal media = soma/quantidade;
                        Conceito conceitogeral;

                        if (media < 2)
                        {
                            conceitogeral = Conceito.E;
                        }
                        else if (media < 4)
                        {
                            conceitogeral = Conceito.D;
                        }
                        else if (media < 6)
                        {
                            conceitogeral = Conceito.C;
                        }
                        else if (media < 8)
                        {
                            conceitogeral = Conceito.B;
                        }
                        else
                        {
                            conceitogeral = Conceito.A;
                        }

                        Console.WriteLine($"A média das notas dos alunos é {media}");
                        Console.WriteLine($"Conceito da média: {conceitogeral}");
                        break;
                    case "4":
                        //TODO: Sair
                        break;
                    default:
                        Console.WriteLine("Digite uma opção válida.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a sua opção:");
            Console.WriteLine();
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular a média geral");
            Console.WriteLine("4- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            return opcaoUsuario;
        }
    }
}
