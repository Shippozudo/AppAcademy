using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ListaExercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //1-Faça um programa que aceite um input digitado pelo usuário, verifique se ele é um digito e imprima na saída do console
            //string input;
            //int digit;
            //bool tryParse;

            //Console.WriteLine("Escreva um digito");
            //input = Console.ReadLine();


            //tryParse = int.TryParse(input, out digit);
            //if(tryParse)
            //{
            //    Console.WriteLine("é um dígito:  " + digit);

            //}
            //else
            //{
            //    Console.WriteLine("Nao é um digito");
            //}



            //2- Faça um programa que aceite um input digitado pelo usuário, transforme o caracter no codigo da tabela ascii e imprima na saída do console

            //string input;

            //Console.WriteLine("Escreva um valor");
            //input = Console.ReadLine();

            //foreach(var i in input)
            //{
            //    Console.WriteLine("conversão ASCII: " + i + " = " +(int)i);

            //}


            //3- Faça um programa que aceite um input numerico digitado pelo usuário,
            //busque o caracter ligado ao codigo e imprima na saída do console, caso contrário informe o erro em tempo de execução

            //string input;
            //char c;
            //Console.WriteLine("Digite um Número: ");
            //input = Console.ReadLine();

            //c = (char)int.Parse(input);

            //Console.WriteLine(c);



            //4 - Faça um programa que aceite um input digitado pelo usuário, verifique se é um caracter maiusculo e imprima na saída do console

            //string input;
            //bool isUpper;

            //Console.WriteLine("Digite um character");
            //input = Console.ReadLine();



            //if (isUpper = Char.IsUpper(Convert.ToChar(input)))
            //{

            //    Console.WriteLine("É maiúsculo: " + input);
            //}
            //else
            //{
            //    Console.WriteLine("não é maiusculo");
            //}


            //5 - Faça um programa que aceite um input digitado pelo usuário, verifique se é um caracter minusculo e imprima na saída do console

            //string input;
            //bool isLower;

            //Console.WriteLine("Digite um character");
            //input = Console.ReadLine();



            //if (isLower = Char.IsLower(Convert.ToChar(input)))
            //{

            //    Console.WriteLine("É minúsculo: " + input);
            //}
            //else
            //{
            //    Console.WriteLine("não é minúsculo");
            //}




            //6 - Faça um programa que transforme um caracter minúsculo em maiúsculo, e imprima na saída do console



            //string input;


            //Console.WriteLine("Digite um character");
            //input = Console.ReadLine();

            //Convert.ToChar(input);
            //Console.WriteLine(input.ToUpper());


            // 7 - Faça um programa que transforme um caracter maiúsculo em minúsculo, e imprima na saída do console

            //string input;


            //Console.WriteLine("Digite um character");
            //input = Console.ReadLine();

            //Convert.ToChar(input);
            //Console.WriteLine(input.ToLower());


            //8 - Faça um programa que aceite um input digitado pelo usuário e o imprima na saída do console

            //string input;

            //Console.WriteLine("Digite um valor");
            //input = Console.ReadLine();
            //Console.WriteLine(input);


            //9- Faça um programa que aceite um input digitado pelo usuário e imprima essa string em letras maiúsculas na saída do console

            //string input;

            //Console.WriteLine("Digite uma string");
            //input = Console.ReadLine();


            //Console.WriteLine(input.ToUpper());


            //10 - Faça um programa que aceite um input digitado pelo usuário e imprima essa string em letras minúsculas na saída do console

            //string input;

            //Console.WriteLine("Digite uma string");
            //input = Console.ReadLine();

            //Console.WriteLine(input.ToLower());

            //11 - Faça um programa que aceite dois inputs digitados pelo usuário, concatene os dois e imprima na saída do console

            //string input1;
            //string input2;

            //Console.WriteLine("Escreva um input1");
            //input1 = Console.ReadLine();

            //Console.WriteLine("Escreva um input2");
            //input2 = Console.ReadLine();

            //Console.WriteLine(string.Concat("Concat: " + input1, " ", input2 ));


            //12 - Faça um programa que aceite um input digitado pelo usuário e imprima essa string ao contrário na saída do console

            //string input;
            //char[] stringReverse;

            //Console.WriteLine("Escreva um input");
            //input = Console.ReadLine();

            //stringReverse = input.ToCharArray();
            //Array.Reverse(stringReverse);

            //Console.WriteLine(stringReverse);


            //13-  Faça um programa que aceite um input digitado pelo usuário, remova os ultimos 4 caracteres e imprima na saída do console

            //string input;

            //Console.WriteLine("Escreva um input");
            //input = Console.ReadLine();

            //input = input.Substring(0, input.Length - 4);

            //Console.WriteLine(input);


            //14 - Faça um programa que aceite um input digitado pelo usuário, troque todas as letras a por b e imprima na saída do console

            //string input;
            //string replace;
            //Console.WriteLine("Escreva um input");
            //input = Console.ReadLine();

            //replace = input.Replace('a', 'b');
            //Console.WriteLine(replace);

            //15 - Faça um programa que aceite um input digitado pelo usuário, divida todas as palavras com uma virgula e imprima a primeira parte na saída do console

            //string input;
            //string replaced;
            //string[] array;



            //Console.WriteLine("Escreva um input");
            //input = Console.ReadLine();

            //replaced = input.Replace(" ", ", ");

            //array = replaced.Split(", ");
            //Console.WriteLine("String splited: " + replaced);
            //Console.WriteLine("Primeiro elemento: " + array[0]);


            //16 - Faça um programa que aceite um input digitado pelo usuário, remova os espaços do inicio e do final e imprima na saída do console

            //string input;
            //string start;
            //string end;

            //Console.WriteLine("Escreva uma frase: ");
            //input = Console.ReadLine();

            //start = input.TrimStart();
            //end = start.TrimEnd();
            //Console.WriteLine(end);

            //17 -Faça um programa que aceite um input digitado pelo usuário, remova todos os caracteres repetidos e imprima na saída do console

            //void Exercicio17(string input)

            //string input;
            //string[] removed;

            //Console.WriteLine("Digite um input");
            //input = Console.ReadLine();

            //Console.WriteLine(new string (input.ToCharArray().Distinct().ToArray()));


            //18- Faça um programa que aceite um input digitado pelo usuário, remova todas as vogais e imprima o resultado na saída do console

            //string input;
            //string vowels = "aeiouAEIOU";
            //string noVowels;

            //Console.WriteLine("Digite um input");
            //input = Console.ReadLine();

            //noVowels = new string(input.Where(x => !vowels.Contains(x)).ToArray());
            //Console.WriteLine(noVowels);

            //19 - Faça um programa que aceite um input digitado pelo usuário e imprima quantas palavras foram escritas na saída do console

            //string input;
            //int count;
            //Console.WriteLine("Escreva um input");
            //input = Console.ReadLine(); 

            //count = input.Split(' ').Length;
            //Console.WriteLine(count);



            // 20 -Escreva um programa C # Sharp para verificar se uma determinada string começa com 'C#' ou não

            //string input;
            //Console.WriteLine("Escreva algo:  ");
            //input = Console.ReadLine();

            //if (input.StartsWith("C#")) 
            //{
            //    Console.WriteLine("A string começa com C#");
            //}
            //else
            //{
            //    Console.WriteLine("Não começa com C#");
            //}

            //21- Faça um programa que aceite um input digitado pelo usuário e imprima quantas vogais e consoantes existem na palavra na saída do console

            //string input;
            //int countVowels = 0;
            //int countConsonants = 0;

            //string vowels = "aeiouAEIOU";
            //string Consonants = "bcdfghjklmnpqrstvxywzBCDFGHJKLMNPQRSTVXYWZ";

            //Console.WriteLine("Escreva um input");
            //input = Console.ReadLine();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    if(vowels.Contains(input[i]))
            //    {
            //        countVowels++;
            //    }
            //    else if(Consonants.Contains(input[i]))
            //    {
            //        countConsonants++;
            //    }

            //}

            //Console.WriteLine("Quantidade de vogais: " + countVowels);
            //Console.WriteLine("Quantidade de consoantes: " + countConsonants);


            //22 - Faça um programa que aceite um input digitado pelo usuário, conte qual é o caracter que mais aparece na string e imprima na saída do console
            //string input;


            //Console.WriteLine("Escreva um input");
            //input = Console.ReadLine(); 

            // var count = input.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            // Console.WriteLine(count);


            //23 - Faça um programa que aceite um input digitado pelo usuário e imprima na saída do console o numero de caracteres do alfabeto, digitos e caracteres especiais

            //string input;
            //int countLetter = 0;
            //int countNumber = 0;
            //int countSpecialChar = 0;

            //string letter = "aeiouAEIOUbcdfghjklmnpqrstvxywzBCDFGHJKLMNPQRSTVXYWZ";
            //string number = "0123456789"; 

            //Console.WriteLine("Escreva um input");
            //input = Console.ReadLine();

            //for (int i = 0; i < input.Length; i++)
            //{

            //    if (letter.Contains(input[i]))
            //    {
            //        countLetter++;
            //    }
            //    else if (number.Contains(input[i]))
            //    {
            //        countNumber++;
            //    }
            //    else
            //    {
            //        countSpecialChar++;

            //    }

            //}

            //Console.WriteLine("Letras: " + countLetter);
            //Console.WriteLine("Numeros: " + countNumber);
            //Console.WriteLine("Character Especial: " + countSpecialChar);

            // 24 -  Faça um programa que aceite um input digitado pelo usuário e imprima a string com seus caracteres separados por um espaço em branco



            //25 - Faça um programa que aceite um input numérico digitado pelo usuário e imprima na saída do console
            //int input = 0;

            //Console.WriteLine("Digite um numero: ");
            //input = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(input);

            //26 - Faça um programa que aceite dois inputs numéricos e imprima o resultado da soma dos dois valores na saída do console

            //int input = 0;
            //int input2 = 0;

            //Console.WriteLine("Digite um numero: ");
            //input = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite outro numero: ");
            //input2 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine(input + input2);


            //27 - Faça um programa que aceite dois inputs numéricos e imprima o resultado do resto da divisão dos dois valores na saída do console



            //int input = 0;
            //int input2 = 0;
            //int resto = 0;

            //Console.WriteLine("Digite um numero: ");
            //input = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite outro numero: ");
            //input2 = Convert.ToInt32(Console.ReadLine());

            //resto = input % input2;
            //Console.WriteLine(resto);

            //28 -Faça um programa que aceite dois inputs numéricos decimais e imprima o resultado
            //do resto da divisão dos dois valores na saída do console com duas casas após a vírgula



            //Console.WriteLine("Digite um numero: ");
            //var input = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite outro numero: ");
            //var input2 = Convert.ToDouble(Console.ReadLine());

            //var resto = input % input2;
            //Console.WriteLine(Math.Round(resto, 2));

            //29 -Faça um programa que aceite dois inputs numéricos decimais e imprima o resultado do
            //resto da divisão dos dois valores na saída do console com duas casas após a vírgula com um cifrão ($) no começo

            //Console.WriteLine("Digite um numero: ");
            //var input = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite outro numero: ");
            //var input2 = Convert.ToDouble(Console.ReadLine());

            //var resto = input % input2;
            //Console.WriteLine("$ " + Math.Round(resto, 2));

            // 30 - Escreva um programa para aceitar dois inteiros e verificar se eles são iguais ou não

            //Console.WriteLine("Digite um numero: ");
            //var input = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite outro numero: ");
            //var input2 = Convert.ToInt32(Console.ReadLine());

            //if(input == input2)
            //{
            //    Console.WriteLine("São iguais");
            //}
            //else
            //{
            //    Console.WriteLine("São diferentes");
            //}


            // 31 - Escreva um programa para verificar se um determinado número é par ou ímpar

            //Console.WriteLine("Digite um numero: ");
            //var input = Convert.ToInt32(Console.ReadLine());

            //if (input % 2 == 0 )
            //{
            //    Console.WriteLine("É par");
            //}
            //else
            //{
            //    Console.WriteLine("É impar");
            //}


            //32 - Escreva um programa C # Sharp para verificar dois números inteiros dados se algum deles está no intervalo 100..200 inclusive

            //Console.WriteLine("Digite um numero: ");
            //var input = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite outro numero: ");
            //var input2 = Convert.ToInt32(Console.ReadLine());

            //if(input >= 100  && input <= 200 || input2 >= 100 && input2 <= 200)
            //{
            //    Console.WriteLine("Está no intervalo de 100 a 200 ");
            //}
            //else
            //{
            //    Console.WriteLine("Não esta no intervalo");
            //}

            //33 - Escreva um programa para verificar se um determinado número é positivo ou negativo 


            //Console.WriteLine("Digite um numero: ");
            //var input = Convert.ToInt32(Console.ReadLine());

            //if (input >= 0)
            //{
            //    Console.WriteLine("Positivo ");
            //}
            //else
            //{
            //    Console.WriteLine("Negativo");
            //}



            //34 - Escreva um programa para descobrir se um determinado ano é um ano bissexto ou não
            //

            //Console.WriteLine("Digite uma data: ");
            //var input = Convert.ToInt32(Console.ReadLine());



            //if(DateTime.IsLeapYear(input))
            //{
            //    Console.WriteLine("Ano bissexto");
            //}
            //else
            //{
            //    Console.WriteLine("Não é bissexto");
            //}


            //35 - Escreva um programa para ler a idade de um candidato e determinar se ele está qualificado para votar (considerar 16 anos de idade)


            //Console.WriteLine("Digite sua idade: ");
            //var input = Convert.ToInt32(Console.ReadLine());

            //if(input >= 16)
            //{
            //    Console.WriteLine("Pode votar");
            //}
            //else
            //{
            //    Console.WriteLine("Nao pode votar");
            //}


            //36 - Escreva um programa para aceitar a altura de uma pessoa em centímetros e categorizar a
            //pessoa de acordo com sua altura(até 1, 40 - anão | até 1, 60 - baixo | até 1, 80 - alto | mais de 1, 80 - gigante)

            //Console.WriteLine("Digite sua idade: ");
            //var input = Convert.ToDouble(Console.ReadLine());

            //if (input <= 1.40)
            //{
            //    Console.WriteLine("Anão");
            //}
            //else if (input <= 1.60)
            //{
            //    Console.WriteLine("Baixo");
            //}
            //else if (input <= 1.80)
            //{
            //    Console.WriteLine("Alto");
            //}
            //else
            //{
            //    Console.WriteLine("Gigante");
            //}


            //37 - Escreva um programa para encontrar o maior de três números

            //Console.WriteLine("Digite sua idade: ");
            //var input1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite sua idade: ");
            //var input2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite sua idade: ");
            //var input3 = Convert.ToInt32(Console.ReadLine());

            //if (input1 > input2 && input1 > input3)
            //{
            //    Console.WriteLine("Maior numero: " + input1);

            //}
            //else if (input2 > input1 && input2 > input3)
            //{
            //    Console.WriteLine("Maior numero: " + input2);

            //}
            //else
            //{
            //    Console.WriteLine("Maior numero: " + input3);
            //}

            //38 - Escreva um programa para armazenar elementos em um array e imprimi-lo.

            //  Console.WriteLine("Digite sua idade: ");
            //  var input = Console.ReadLine();
            //  string[] armazenar;


            //  armazenar = input.Split(" ");


            //foreach(var i in armazenar)
            //{
            //      Console.WriteLine(i);
            //}

            // 39 - Escreva um programa para ler n número de valores em um array e exibi-lo na ordem inversa

            //Console.WriteLine("Digite a quantide de valores: ");
            //var n = Convert.ToInt32(Console.ReadLine());
            //List<int> valores = new List<int>();

            //for (int i = 0; i < n; i++)
            //{


            //    Console.WriteLine("Digite um numero : ");
            //    int input = Convert.ToInt32(Console.ReadLine());

            //    valores.Add(input);

            //}

            //valores.Reverse(0, n);

            //Console.WriteLine("Reversed: ");
            //for (int i = 0; i < n; i++)
            //{

            //    Console.WriteLine(valores[i]);
            //}

            //40 - Escreva um programa para encontrar a soma de todos os elementos do array

            //Console.WriteLine("Digite a quantide de valores: ");
            //var n = Convert.ToInt32(Console.ReadLine());
            //int soma = 0;

            //List<int> valores = new List<int>();

            //for (int i = 0; i < n; i++)
            //{


            //    Console.WriteLine("Digite um numero : ");
            //    int input = Convert.ToInt32(Console.ReadLine());

            //    valores.Add(input);
            //    soma += valores[i];

            //}
            //Console.WriteLine("Soma: " + soma);

            //41 - Escreva um programa em para copiar os elementos de um array para outro array

            //Console.WriteLine("Digite a quantide de valores: ");
            //var n = Convert.ToInt32(Console.ReadLine());
            //List<int> valores = new List<int>();
            //List<int> valores2 = new List<int>();

            //for (int i = 0; i < n; i++)
            //{


            //    Console.WriteLine("Digite um numero : ");
            //    int input = Convert.ToInt32(Console.ReadLine());

            //    valores.Add(input);
            //    valores2.Add(valores[i]);
            //}

            //Console.WriteLine("Array copiado: ");
            //for (int i = 0;i < n; i++)
            //{
            //    Console.WriteLine(valores2[i]);
            //}

            //42 - Escreva um programa em para contar o número total de elementos duplicados em um array

            //Console.WriteLine("Digite a quantide de valores: ");
            //var n = Convert.ToInt32(Console.ReadLine());
            //List<int> valores = new List<int>();


            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Digite um numero : ");
            //    int input = Convert.ToInt32(Console.ReadLine());

            //    valores.Add(input);
            //}

            //valores.Sort();
            //var igual = 0;
            //for (int i = 0; i < n; i++)
            //{

            //    for (int j = i + 1; j < n; j++)
            //    {

            //        if (valores[i] == valores[j])
            //        {
            //            igual++;
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine("Quantidade de Items duplicados: " + igual);

            //43- Escreva um programa para imprimir todos os elementos únicos em um array


            //Console.WriteLine("Digite a quantide de valores: ");
            //var n = Convert.ToInt32(Console.ReadLine());
            //List<int> valores = new List<int>();


            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Digite um numero : ");
            //    int input = Convert.ToInt32(Console.ReadLine());

            //    valores.Add(input);
            //}

            //List <int> uniqueValues = valores.Distinct().ToList();

            //foreach(int a in uniqueValues)
            //{
            //    Console.WriteLine(a);
            //}


            // 44 - Escreva um programa em para encontrar o elemento máximo e mínimo em um array


            //Console.WriteLine("Digite a quantide de valores: ");
            //var n = Convert.ToInt32(Console.ReadLine());
            //List<int> valores = new List<int>();


            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Digite um numero : ");
            //    int input = Convert.ToInt32(Console.ReadLine());

            //    valores.Add(input);
            //}


            //Console.WriteLine("Min: " + valores.Min());
            //Console.WriteLine("Max: " + valores.Max());

            // 45 -Escreva um programa  para separar inteiros pares e ímpares em arrays separados


            //Console.WriteLine("Digite a quantide de valores: ");
            //var n = Convert.ToInt32(Console.ReadLine());
            //List<int> par = new List<int>();
            //List<int> impar = new List<int>();

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Digite um numero : ");
            //    int input = Convert.ToInt32(Console.ReadLine());

            //    if (input % 2 == 0)
            //    {
            //        par.Add(input);
            //    }   
            //    else
            //    {
            //        impar.Add(input);
            //    }
            //}

            //for (int i = 0; i < par.Count(); i++)
            //{

            //    Console.WriteLine("par: " + par[i]);

            //}

            //for (int i = 0; i < impar.Count(); i++)
            //{

            //    Console.WriteLine("impar: " + impar[i]);

            //}

            // 46 - Escreva um programa para recuperar a data atual
            // 

            //Console.WriteLine(DateTime.Now);


            // 47 - Escreva um programa que compare duas datas. 

            //var today = DateTime.Now;
            //var day = today.AddDays(5);

            //Console.WriteLine(DateTime.Compare(today, day));


            //48 - Escreva um programa para obter o número de dias do mês e ano especificados.
            //passar ano e mes, e o programa entrega os dias do mes

            //Console.WriteLine("Digite ano");
            //int ano = Convert.ToInt32(Console.ReadLine()); 

            //Console.WriteLine("Digite mês");
            //int mes = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("");
            //Console.WriteLine(DateTime.DaysInMonth(ano, mes));

            // 49 - Escreva um programa para calcular que dia será amanhã

            //Console.WriteLine("Data de amanha: " + DateTime.Now.AddDays(1));


            // 50 - Escreva um programa para determinar o dia da semana 40 dias após a data atual

            //Console.WriteLine("Data daqui a 40 dias: " + DateTime.Now.AddDays(40));


            //51 - Escreva um programa para adicionar o número especificado de meses (entre zero e quinze meses) ao último dia de agosto de 2016

            //DateTime date = new DateTime(2016, 08, 31);


            //Console.WriteLine("Escreva um mês, entre 0 e 15");
            //int month = Convert.ToInt32(Console.ReadLine());

            //if (month >= 0 && month <= 15)
            //{
            //    Console.WriteLine("Data, 31 agosto de 2016, + {0} meses , {1} ", month, date.AddMonths(month));

            //}
            //else
            //{
            //    Console.WriteLine("Mês invalido");
            //}


            // 52 - Escreva um programa para exibir a data de quinze anos passados ​​e futuros de uma data especificada

            //Console.WriteLine("Escreva um ano");

            //string data = Console.ReadLine();

            //DateTime result;
            //DateTime.TryParse(data, out result);



            //Console.WriteLine(result.AddYears(15));
            //Console.WriteLine(result.AddYears(-15));

            // 53 - Escreva um programa para extrair a propriedade Date e exibir o valor DateTime na saída formatada.

            //Console.WriteLine("Escreva um dia/mes/ano");
            //string data = Console.ReadLine();


            //DateTime result;
            //DateTime.TryParse(data, out result);

            //Console.WriteLine(result.Day);
            //Console.WriteLine(result.DayOfWeek);



            // 54 -Escreva um programa para exibir as propriedades do dia (ano, mês, dia, hora, minuto, segundo, milissegundo, etc.)

            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.Now.Millisecond);




            // 55 -Escreva um programa para criar um arquivo em branco no disco

            //var file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile.txt"); //cria variavel e combina o nome do arquivo com o diretorio


            //var blanckFile = File.Create(file); //cria o file a partir do combine
            //Console.WriteLine("Arquivo criado");


            // 56 - Escreva um programa para remover um arquivo do disco

            //var file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile.txt"); //cria variavel e combina o nome do arquivo com o diretorio


            //var blanckFile = File.Create(file); //cria o file a partir do combine
            //Console.WriteLine("Arquivo criado");
            //blanckFile.Close();

            //File.Delete(file);

            // 57 - Escreva um programa para criar um arquivo em branco no disco se o mesmo arquivo já existir.
            // 

            //var file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile.txt"); //cria variavel e combina o nome do arquivo com o diretorio
            //var blanckFile = File.Create(file); //cria o file a partir do combine
            //blanckFile.Close();


            //if (File.Exists(file))
            //{
            //    Console.WriteLine("File exist;");

            //    file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile.txt"); //cria variavel e combina o nome do arquivo com o diretorio
            //    blanckFile = File.Create(file); //cria o file a partir do combine

            //    Console.WriteLine("Arquivo criado");


            //}
            //else
            //{
            //    Console.WriteLine("File didnt exist");
            //}

            //58 -Escreva um programa para criar um arquivo e adicionar algum texto


            //var file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile3.txt"); //cria variavel e combina o nome do arquivo com o diretorio
            //var blanckFile = File.Create(file); //cria o file a partir do combine
            //blanckFile.Close();

            //System.IO.File.WriteAllText(file, "TEXTO TO ADD");


            //59 - Escreva um programa para criar um arquivo com texto e ler o arquivo


            //var file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile3.txt"); //cria variavel e combina o nome do arquivo com o diretorio
            //var blanckFile = File.Create(file); //cria o file a partir do combine
            //blanckFile.Close();

            //System.IO.File.WriteAllText(file, "TEXTO TO ADD" + "ahahhaha ");

            //string read = File.ReadAllText(file);
            //Console.WriteLine(read);

            //blanckFile.Close();


            // 60 - Escreva um programa para criar um arquivo e escrever uma série de strings para o arquivo



            //var file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile3.txt"); //cria variavel e combina o nome do arquivo com o diretorio
            //var blanckFile = File.Create(file); //cria o file a partir do combine
            //blanckFile.Close();

            //System.IO.File.WriteAllText(file, "TEXTO TO ADD" + "\n ahahhaha " + "\nlellele" + " \nlalalalal");

            //string read = File.ReadAllText(file);
            //Console.WriteLine(read);

            //blanckFile.Close();

            // 61 -Escreva um programa para anexar algum texto a um arquivo existente.


            //StreamWriter writeOnFile = File.AppendText("BlanckFile3.txt");

            //writeOnFile.WriteLine("\n xurastei xuraigou");

            //writeOnFile.Close();


            //62 - Escreva um programa para criar e copiar o arquivo com outro nome e exibir o conteúdo


            //var file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile4.txt"); //cria variavel e combina o nome do arquivo com o diretorio
            //var blanckFile = File.Create(file); //cria o file a partir do combine
            //blanckFile.Close();

            //System.IO.File.WriteAllText(file, "TEXTO TO ADD" + "\n ahahhaha " + "\nlellele" + " \nlalalalal");


            //File.Copy(file, "copyfile2.txt");

            //string read = File.ReadAllText("copyfile2.txt");

            //Console.WriteLine(read);

            //blanckFile.Close();



            //63 - Escreva um programa para criar um arquivo e mover o arquivo para o mesmo diretório com outro nome


            //var file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile4.txt"); //cria variavel e combina o nome do arquivo com o diretorio
            //var blanckFile = File.Create(file); //cria o file a partir do combine
            //blanckFile.Close();

            //System.IO.File.WriteAllText(file, " Sextouuuuuuu");

            //File.Copy(file, "CopyBlanckFile4.txt");

            //string readCopy = File.ReadAllText("CopyBlanckFile4.txt");
            //Console.WriteLine(readCopy);

            //blanckFile.Close();




            //64 - Escreva um programa para criar e ler a última linha de um arquivo

            //var file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile4.txt"); //cria variavel e combina o nome do arquivo com o diretorio
            //var blanckFile = File.Create(file); //cria o file a partir do combine
            //blanckFile.Close();

            //System.IO.File.WriteAllText(file, " \n Sextouuuuuuu" + " \n carai" + " \n nois q ta" + " \n cabouuu");

            //string read = File.ReadLines(file).Last();
            //Console.WriteLine(read);

            //blanckFile.Close();

            //65 - Escreva um programa para ler uma linha específica de um arquivo

            //var file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile4.txt"); //cria variavel e combina o nome do arquivo com o diretorio
            //var blanckFile = File.Create(file); //cria o file a partir do combine
            //blanckFile.Close();

            //System.IO.File.WriteAllText(file, " \n Sextouuuuuuu" + " \n carai" + " \n nois q ta" + " \n cabouuu");

            //string read = File.ReadLines(file).ElementAt(1);

            //Console.WriteLine(read);

            //blanckFile.Close();

            //66 - Escreva um programa para contar o número de linhas em um arquivo

            //var file = Path.Combine(Directory.GetCurrentDirectory(), "BlanckFile4.txt"); //cria variavel e combina o nome do arquivo com o diretorio
            //var blanckFile = File.Create(file); //cria o file a partir do combine
            //blanckFile.Close();

            //System.IO.File.WriteAllText(file, " \n Sextouuuuuuu" + " \n carai" + " \n nois q ta" + " \n cabouuu");

            //int read = File.ReadLines(file).Count();

            //Console.WriteLine(read);

            //blanckFile.Close();

            //67 - Dado o tamanho da base e da altura de um retângulo, calcular a sua área e o seu perímetro.
            //


        }


    }

       
}
