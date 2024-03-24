using System;

namespace POC
{
    internal class Program
    {
        //Passo 1 - Declarar Variaveis        
        static int retornoCalcularMediaAnual;
        static bool retornoRegraMediaAnual;

        static void Main(string[] args)
        {
            //Passo 2 - Realizar input de notas anuais
            Notas notas = new Notas();
            notas = CapturarNotas();

            //Passo 3 - Realizar Cálculo de Média Anual na classe Notas
            retornoCalcularMediaAnual = notas.CalcularMediaAnual(notas);

            //Passo 4 - Realizar Validação da Média Anual na classe Notas
            retornoRegraMediaAnual = notas.AplicarRegraMediaAnual(retornoCalcularMediaAnual);

            //Passo 5 - Apresentar Mensagem de Media Anual (aprovado/reprovado)
            ApresentarMensagemMediaAnual(retornoRegraMediaAnual);
        }

        private static Notas CapturarNotas()
        {
            Notas notas = new Notas();

            //Label
            Console.WriteLine("Informar a nota1: ");
            //Entrada realizada pelo usuário
            //Toda entrada realizada pelo usuário é STRING
            //Converter o dado que existe dentro do Console.ReadLine que é string para o tipo da 
            //variavel definida (ex: string --> int)
            notas.Nota1 = Convert.ToInt16(Console.ReadLine());

            //Label
            Console.WriteLine("Informar a nota2: ");
            //Entrada realizada pelo usuário
            //Toda entrada realizada pelo usuário é STRING
            //Converter o dado que existe dentro do Console.ReadLine que é string para o tipo da 
            //variavel definida (ex: string --> int)
            notas.Nota2 = Convert.ToInt16(Console.ReadLine());

            //Label
            Console.WriteLine("Informar a nota3: ");
            //Entrada realizada pelo usuário
            //Toda entrada realizada pelo usuário é STRING
            //Converter o dado que existe dentro do Console.ReadLine que é string para o tipo da 
            //variavel definida (ex: string --> int)
            notas.Nota3 = Convert.ToInt16(Console.ReadLine());

            //Label
            Console.WriteLine("Informar a nota4: ");
            //Entrada realizada pelo usuário
            //Toda entrada realizada pelo usuário é STRING
            //Converter o dado que existe dentro do Console.ReadLine que é string para o tipo da 
            //variavel definida (ex: string --> int)
            notas.Nota4 = Convert.ToInt16(Console.ReadLine());

            return notas;
        }

        private static void ApresentarMensagemMediaAnual(bool retornoRegraMediaAnual)
        {
            if (retornoRegraMediaAnual)
            {
                Console.WriteLine(String.Format("Aluno Aprovado: {0}", retornoCalcularMediaAnual));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Aluno reprovado " + retornoCalcularMediaAnual);
                Console.ReadKey();
            }
        }
    }
}