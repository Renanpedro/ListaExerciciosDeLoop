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
            Console.WriteLine("Qual exercicio você que testar? ");
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
                default: Menu(); break;
            }
        }

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
    }
}
