using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFuncWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp;
            int cont = 0;
            double sal_b = 0;
            double sal_total = 0;
            Console.WriteLine("Deseja começar[S-Sim, N-Não]: ");
            resp = Console.ReadLine().ToUpper();

            while(resp == "S")
            {
                Console.WriteLine("Qual a forma de contratação do funcionário [A-Assalariado,C-Comissionado, H-Horista]: ");
                string f_con = Console.ReadLine().ToLower();

                switch (f_con)
                {
                    case "a":
                        Console.Write("Qual o a salário de funcionário: ");
                        double sal = double.Parse(Console.ReadLine());

                        Console.Write("Qual o desconto: ");
                        double desc = double.Parse(Console.ReadLine());

                        sal_b = sal - desc;
                        Console.WriteLine("O salário bruto é R$" + sal_b);

                        sal_total += sal_b;
                        cont++;
                        break;

                    case "c":
                        Console.Write("Quantas peças o funcionário vendeu: ");
                        int q_pe = int.Parse(Console.ReadLine());
                        Console.Write("Qual o valor por peça: ");
                        double v_pe = double.Parse(Console.ReadLine());

                        sal_b = q_pe * v_pe;
                        Console.WriteLine("O salário bruto é R$" + sal_b);
                        sal_total += sal_b;
                        cont++;
                        break;

                    case "h":

                        Console.Write("Qual o valor por hora: ");
                        double v_h = double.Parse(Console.ReadLine());

                        Console.Write("Qual a quantidade de horas trabalhadas: ");
                        int q_h = int.Parse(Console.ReadLine());

                        sal_b = v_h * q_h;
                        Console.WriteLine("O salário bruto é R$" + sal_b);
                        sal_total += sal_b;
                        cont++;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                Console.WriteLine("Deseja continuar: ");
                resp = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("A quantidade de funcionários cadastrados foi: " + cont);
            Console.WriteLine("O total da folha de pagamento é de: " + sal_total.ToString("C"));
            Console.WriteLine("A média de salário é: " + (sal_total / cont).ToString("C"));
            Console.ReadKey();
        }
    }
}
