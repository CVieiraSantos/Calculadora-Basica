using System;
using System.Globalization;

namespace BaltaFundamentosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Menu();
        }

        static void Soma()
        {
            try
            {
                Console.Clear();
                Console.Write("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                float resultado = (v1 + v2);
                        
                Console.WriteLine($"O resultado da subtração é: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");         
                Console.ReadLine();
                Menu();                
            }

            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Operação finalizada. Obrigado por utilizar o sistema de operações matemática");
            }
            
        }

        static void Subtracao()

        {
            try
            {
                Console.Clear();
                Console.Write("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                float resultado = (v1 - v2);
                        
                Console.WriteLine($"O resultado da subtração é: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.ReadLine();
                Menu();
            }

            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Operação finalizada. Obrigado por utilizar o sistema de operações matemática");
            }


        }

        static void Divisao()
        {
            try
            {
                Console.Clear();
                Console.Write("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                float resultado = (v1 / v2);
                        
                Console.WriteLine($"O resultado da divisão é: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.ReadLine();
                Menu();
            }

            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Operação finalizada. Obrigado por utilizar o sistema de operações matemática");
            }


        }

        static void Multiplicacao()
        {
            try
            {
                Console.Clear();
                Console.Write("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                float resultado = (v1 * v2);
                        
                Console.WriteLine($"O resultado da multiplicação é: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.ReadLine();
                Menu();
            }

            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Operação finalizada. Obrigado por utilizar o sistema de operações matemática");
            }

            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Por favor escolha uma das operações abaixo");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Selecione uma das opções");

            try
            {
                short operacao = short.Parse(Console.ReadLine());

                switch(operacao)
                {
                    case 1: Soma(); break;
                    case 2: Subtracao(); break;
                    case 3: Divisao(); break;
                    case 4: Multiplicacao(); break; 
                    case 5: System.Environment.Exit(0); break;
                    default: Menu(); break;                    
                }                
            }            

            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            catch(Exception e)
             {
                 Console.WriteLine(e.Message);
             }

             
             finally
             {
                 Console.WriteLine("Operação finalizada. Obrigado por utilizar o sistema de operações matemática");
             }


            
        }
    }
}
