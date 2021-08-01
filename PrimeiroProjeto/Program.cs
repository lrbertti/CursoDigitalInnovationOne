using System;

namespace PrimeiroProjeto
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcaoUsuario = setMenu();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        //TODO: Adcionar aluno
                        Console.WriteLine("Informe o nome do Aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Informe a nota do Aluno");
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;        
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota deve ser decimal!");
                        }
                        
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;

                    case "2":
                        //TODO: listar aluno
                        foreach(Aluno al in alunos)
                        {
                            if(!string.IsNullOrEmpty(al.Nome))
                                Console.WriteLine($"Aluno: {al.Nome} - Nota: {al.Nota}");
                        }
                        break;

                    case "3":
                        //TODO: calcular media geral
                        decimal notaTotal = 0;
                        int nrAlunos = 0;

                        for(int i=0; i <alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal += alunos[i].Nota;
                                nrAlunos ++;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Conceito conceitoGral;
                        if(2 >= mediaGeral)
                        {
                            conceitoGral = Conceito.E;
                        }
                        else if(mediaGeral <=4)
                        {
                            conceitoGral = Conceito.D;
                        }
                        else if(mediaGeral <=6)
                        {
                            conceitoGral = Conceito.C;
                        }
                        else if(mediaGeral <=8)
                        {
                            conceitoGral = Conceito.B;
                        }
                        else
                        {
                            conceitoGral = Conceito.A;
                        }
                        Console.WriteLine($"Media Geral: {mediaGeral} -  Conceito: {conceitoGral} ");
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = setMenu();
            }
        }

        private static string setMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a oprcao desejada:");
            Console.WriteLine("1-Inserir novo aluno");
            Console.WriteLine("2-Listar alunos");
            Console.WriteLine("3-Calcular média geral");
            Console.WriteLine("X-Sair");
            Console.WriteLine();

            return Console.ReadLine();
        }
    }
}
