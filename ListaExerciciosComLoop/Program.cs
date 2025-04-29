using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace ListaDeExercicios
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("1 - Contar de 1 até 5");
            Console.WriteLine("2 - Contar de 10 até 1");
            Console.WriteLine("3 - Somar os numeros de 1 até 10");
            Console.WriteLine("4 - Mostrar apenas números pares de 0 a 10");
            Console.WriteLine("5 - Concatenar números em uma string");
            Console.WriteLine("6 - Pedir uma senha correta");
            Console.WriteLine("7 - Tabuada do 2");
            Console.WriteLine("8 - Contar quantas vezes aparece o número 3 em um array");
            Console.WriteLine("9 - Mostrar apenas letras de uma palavra");
            Console.WriteLine("10 - Mostrar todos os números de 1 a 20, mas pular os múltiplos de 4");
            Console.WriteLine("11 - Somar os números ímpares entre 1 e 100");
            Console.WriteLine("12 - Inverter os caracteres de uma string");
            Console.WriteLine("13 - Calcular a média de um array de notas");
            Console.WriteLine("14 - Verificar se uma palavra é um palíndromo");
            Console.WriteLine("15 - Contar quantas vogais existem em uma frase");
            Console.WriteLine("16 - Mostrar a sequência de Fibonacci até o 20º número");
            Console.WriteLine("17 - Mostrar os divisores de um número inteiro");
            Console.WriteLine("18 - Verificar se todos os elementos de um array são positivos");
            Console.WriteLine("19 - Substituir números pares por “P” e ímpares por “I” em um array");
            Console.WriteLine("20 - Jogo da adivinhação");
            Console.Write("Qual exercicio você que testar? ");
            int opcao = int.Parse(Console.ReadLine());            

            switch (opcao)
            {
                case 1: ContarAte5(); break;
                case 2: De10pra1(); break;
                case 3: SomarAte10(); break;
                case 4: NumerosPar(); break;
                case 5: ConcatenarNumeroString(); break;
                case 6: PedirUmaSenha(); break;
                case 7: TabuadaDoDois(); break;
                case 8: NumeroTresNoArray(); break;
                case 9: LetrasDaPalavra(); break;
                case 10: NumerosDeUmAteVinte(); break;
                case 11: SomarImpares1a100(); break;
                case 12: InverterOscaracteresDoTexto(); break;
                case 13: CalcularMediaArray(); break;
                case 14: PalavraPalindromo(); break;
                case 15: ContarVogaisNaFrase(); break;
                case 16: SequenciaDeFibonacci(); break;
                case 17: DivisoresNumeroInteiro(); break;
                case 18: PositivosNoArray(); break;
                case 19: SubstituirNumeroPorLetra(); break;
                case 20: AdivinheONumero(); break;
                default: Menu(); break;
            }
        }

        #region Primeira Lista de Exercicios
        static void ContarAte5()
        {
            int Inicio = 1;
            while(Inicio <= 5)
            {
                System.Console.WriteLine($"Numero: {Inicio}");
                Inicio++;
            }

            Console.ReadKey();
            Menu();
        }
   
        static void De10pra1()
        {
            int Inicio = 10;
            for(int i = 10; i >= 1 ; i--)
            {
                System.Console.WriteLine($"Contagem Regressiva: {Inicio}");
                Inicio--;
            } 

            Console.ReadKey();
            Menu();
        }
    
        static void SomarAte10()
        {
            int Soma = 0;
            for(int i = 1; i <=10 ; i++)
            {
                Soma += i;
            }

            System.Console.WriteLine($"A soma dos números 1 até 10 é: {Soma}");
            Console.ReadKey();
            Menu();
        }

        static void NumerosPar()
        {
            int numero = 0;
            while(numero <= 10)
            {
                if(numero % 2 == 0)
                    System.Console.WriteLine($"O número {numero} é par");
                numero++;
            }

            Console.ReadKey();
            Menu();
        }
    
        static void ConcatenarNumeroString()
        {
            string texto = string.Empty;
            for(int i = 1; i <= 5; i++)
            {
                texto = texto + i.ToString();
            }

            System.Console.WriteLine($"Resultado da concatenação é: {texto}");
            Console.ReadKey();
            Menu();
        }
    
        static void PedirUmaSenha()
        {
            string senhaInformada = string.Empty;

            do
            {
                System.Console.WriteLine("Informe a sua senha: ");
                senhaInformada = Console.ReadLine();

            } while(senhaInformada != "1234");

            System.Console.WriteLine($"A senha correta foi informada: {senhaInformada}");
            Console.ReadKey();
            Menu();
        }
    
        static void TabuadaDoDois()
        {
            System.Console.WriteLine("Tabudada do número 2");
            for(int i = 1; i <= 10; i++)
            {     
                System.Console.WriteLine($"2 x {i} = {2*i}" );
            }

            Console.ReadKey();
            Menu();
        }
    
        static void NumeroTresNoArray()
        {
            int[] arrayNumeros = {1, 3, 5, 3, 7, 3, 9};
            int qtdNumeroTres = 0;
            
            // foreach(int i in arrayNumeros)
            for(int i = 0; i <= arrayNumeros.Length; i++)
            {
                if(i == 3)
                    qtdNumeroTres++;
            }

            System.Console.WriteLine($"O número 3 apareceu {qtdNumeroTres} dentro do array.");
            Console.ReadKey();
            Menu();
        }
    
        static void LetrasDaPalavra()
        {
            string palavra = "javascript";
            for(int i = 0; i <= palavra.Length; i++)
            {
                System.Console.WriteLine(palavra[i]);
            }

            Console.ReadKey();
            Menu();
        }
    
        static void NumerosDeUmAteVinte()
        {
            for(int i = 1; i <= 20; i++)
            {
                if(!(i % 4 == 0))
                {
                    System.Console.WriteLine(i);
                }
            }

            Console.Read();
            Menu();
        }

        static void SomarImpares1a100()
        {
            int soma = 0;
            for(int i = 0; i <= 100; i++)
            {
                if(!(i % 2 == 0))
                    soma = soma + i;
            }

            System.Console.WriteLine($"A soma dos números impares de 1 a 100 é {soma}");
            Console.ReadKey();
            Menu();
        }
        #endregion

        #region Segunda Lista de Exercicios
            static void InverterOscaracteresDoTexto()
            {
                string texto = "Texto correto informado";
                var textoInvertido = new StringBuilder();
                for(int i = texto.Length - 1; i >= 0; i--)
                {
                    textoInvertido.Append(texto[i]);
                }

                Console.WriteLine($"O texto original é {texto}, invertido ele fica da seguinte forma: {textoInvertido}");

                Console.ReadKey();
                Menu();
            }
            static void CalcularMediaArray()
            {
                double[] notas = { 7.5, 8.2, 9.0, 6.4, 10 };
                double total = 0;
                double media = 0;

                foreach(double nota in notas)
                {
                    total = total + nota;
                }

                media = total / notas.Length;
                System.Console.WriteLine($"A média das notas é {media:F2}");
                Console.ReadKey();
                Menu();
            }
            static void PalavraPalindromo()
            {
                string palavra = "arara";
                var palavraInvertida = new StringBuilder();

                for(int i = palavra.Length - 1; i >= 0; i--)
                {
                    palavraInvertida.Append(palavra[i]);
                }
                
                bool palindromo = palavraInvertida.ToString() == palavra;
                
                if(palindromo)
                    System.Console.WriteLine($"Sim, a palavra {palavra} é um palindromo");
                else
                    System.Console.WriteLine($"Não, a palavra {palavra} não é um palíndromo");
            }
            static void ContarVogaisNaFrase()
            {
                string frase = "Programar é muito divertido!";
                frase = frase.ToLower();
                string[] arrayvogais = {"a", "e", "i", "o", "u"};
                int qtdVogais = 0;

                for(int i = 0; i < frase.Length; i++)
                {
                    if(arrayvogais.Contains(frase[i].ToString()))
                        qtdVogais++;
                }

                System.Console.WriteLine($"A frase {frase} contém {qtdVogais} vogais");
                Console.ReadKey();
                Menu();
            }
            static void SequenciaDeFibonacci()
            {
                var sequenciaFibonnaci = new StringBuilder();
                int primeiroNumero = 0;
                int segundoNumero = 1;
                
                sequenciaFibonnaci.Append($"{primeiroNumero.ToString()}, {segundoNumero.ToString()}");

                for(int i = 2; i <= 20; i++)
                {
                    int proximoNumero = primeiroNumero + segundoNumero;
                    sequenciaFibonnaci.Append($" {proximoNumero}");
                    primeiroNumero = segundoNumero;
                    segundoNumero = proximoNumero;
                }

                System.Console.WriteLine(sequenciaFibonnaci);
            }
            static void DivisoresNumeroInteiro()
            {
                System.Console.Write("Informe um numero inteiro que irei te passar quais são os seus divisores: ");
                int numeroInformado = int.Parse(Console.ReadLine());
                var divisores = new StringBuilder();

                for(int i = 1; i <= numeroInformado; i++)
                {
                    if(numeroInformado % i == 0) 
                        divisores.Append($" {i} ");
                }

                System.Console.WriteLine($"Os divisores do número {numeroInformado} são os numeros: {divisores}");
                Console.ReadKey();
                Menu();
            }
            static void PositivosNoArray()
            {
                int[] numeros = { 1, 2, -3, 4, 10, -15, 40, -9, -7, -8, 40, 25, 43 };
                var numerosNegativos = new StringBuilder();
                bool existeNumeroNegativo = false;

                foreach(int numero in numeros)
                {
                    if(numero < 0)
                    {
                        existeNumeroNegativo = true;
                        numerosNegativos.Append($" {numero.ToString()} ");
                    }
                }

                if(existeNumeroNegativo)
                System.Console.WriteLine($"Existe numeros negativos no array, números negativos encontrados: {numerosNegativos}");
                else
                    System.Console.WriteLine($"Não existe números negativos no array");
                    
                Console.ReadKey();
                Menu();
            } 
            static void SubstituirNumeroPorLetra()
            {
                int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var numerosTrocadosPorLetras = new StringBuilder();

                for(int i = 0; i < numeros.Length; i++)
                {
                    if(numeros[i] % 2 == 0)
                        numerosTrocadosPorLetras.Append(" P ");
                    else
                        numerosTrocadosPorLetras.Append(" I ");
                }

                System.Console.WriteLine(numerosTrocadosPorLetras);
                Console.ReadKey();
                Menu();
            }
            static void AdivinheONumero()
        {
            int numeroSorteado = new Random().Next(0, 100);
            int chuteUsuario = 0;

            do{
                System.Console.WriteLine("Qual numero você acha que foi sorteado? ");
                chuteUsuario = int.Parse(Console.ReadLine());
                System.Console.WriteLine("");

                if(chuteUsuario > numeroSorteado)
                    System.Console.WriteLine($"O número sorteado é menor que {chuteUsuario}");
                else if(chuteUsuario < numeroSorteado)
                    System.Console.WriteLine($"O número sorteado é maior que {chuteUsuario}");
                
                System.Console.WriteLine("");
            } while(numeroSorteado != chuteUsuario);

            System.Console.WriteLine($"Parabéns você descobriu, o número sorteado foi o: {chuteUsuario} ");
            Console.ReadKey();
            Menu();
        }
        #endregion

    }
}
