using System;
using System.Runtime.InteropServices.Marshalling;

namespace Passeio
{
    class Passeio
    {
        static void Main(string[] args)
        {

            String opcao = "";

            do
            {

                int aluno = 0, inspetor = 0, onibus = 0, i = 1;

                Console.WriteLine("Digite quantos alunos irão: ");
                aluno = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite quantos inspetores irão: ");
                inspetor = int.Parse(Console.ReadLine());

                if(inspetor == 0)
                {
                    Console.WriteLine("Não e possível sair sem inspetores");
                    return;
                }

                if (aluno <= 0 && inspetor <= 0)
                {

                    Console.WriteLine("E priciso ter pelo menos 1 inspetores e 1 aluno");

                }

                for (int cont = 0; cont < i; cont++)
                {

                    if (inspetor == 0 && aluno> 0)
                    {
                           Console.WriteLine("A quantidade de inspetores e insuficiente");                     
                    }

                    if ((aluno - 9) >= 0 && (inspetor - 1) >= 0)
                    {
                        aluno = aluno - 9;
                        inspetor--;
                        onibus++;
                        i++;
                    }
                    else if (aluno > 0 && aluno < 9)
                    {
                        inspetor = inspetor - (10 - aluno);
                        aluno = aluno - aluno;
                        onibus++;
                        i++;
                    }
                    else if (aluno == 0 && inspetor > 0)
                    {
                        if ((inspetor - 10) >= 0)
                        {
                            inspetor = inspetor - 10;
                            onibus++;
                            i++;
                        }
                        else if (inspetor > 0 && inspetor < 10)
                        {
                            inspetor = inspetor - inspetor;
                            onibus++;
                            i++;
                        }
                    }
                }

                Console.WriteLine("A quantidade de ônibus nesessarios e de: " + onibus);
                Console.WriteLine("Deseja repetir(s/n): ");
                opcao = Console.ReadLine();

            } while (opcao != "n");
        }
    }

}

