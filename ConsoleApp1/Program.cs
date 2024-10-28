//1 zadanie
using System;

int n = 0;
do
{
    Console.WriteLine(n) ; 
    n++ ;
}  while (n < 11);


//2 zadanie
//string password = "";
//do
//{
//    Console.WriteLine("podaj haslo :) ");
//    password = Console.ReadLine();
//} while (password != "a");

//3 zadanie
int a = 1;
Console.WriteLine("Liczbe parzyste : ");
while (a <= 100) {
    if (a % 2 == 0) ;
    Console.WriteLine(a);
    a++ ;
}

//4 zadanie
for (int i = 1; i <= 15; i++)
{
     Console.WriteLine($"Square of {i} equals {i * i}");
}

//5 zadanie //6 zadanie (dod break
List<int> numbers = new List<int>() { 4, 25, 35, 42, 55, 78, 99, 101 };
foreach (int i in numbers)
{
    if (i % 7 == 0)
    {
        Console.WriteLine($"{i}");
        break;
    }
}
    

//7 zadanie
double[] dArray = new double[20];
for (int i = 0; i < 20; i++)
{
    dArray[i] = Math.Sqrt(i);
    Console.WriteLine("i: " + dArray[i]);
}

//8 zadanie
////deklaracja tablicy dwuwymiarowej
//int[,] m = new int[3, 4];
////wypelnienie danymi
//for (int column = 0; column < 3; column++)
//{
//    for (int row = 0; row < 4; row++)
//    {
//        //wypelnienie liczba calkowita np. column + row
//        m[row, column] = column + row;
//    }
//}
////transpozycja
//int[,] t = new int[4, 3];
//for (int column = 0; column < 3; column++)
//{
//    for (int row = 0; row < 4; row++)
//    {
//        t[row, column] = m[column, row];
//    }
//}

//int[,] m = new int[3,4];
//int value = 1;
//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        m[i,j] = value;
//        value++;
//    }
//}
//Console.WriteLine("Macierz po transpozycji:");
//for (int i = 0;i < 4; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.WriteLine(m[i,j] + " ");
//    }
//    Console.WriteLine();
//}

int[,] matrix = new int[3, 4];

int value = 1;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = value;
        value++;
    }
}

// Wyświetlenie macierzy po transpozycji
Console.WriteLine("Macierz po transpozycji:");
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrix[j, i] + " ");
    }
    Console.WriteLine();
}

//Koniec Zadania 8/9

//Zadanie 10 
//Zdefiniuj procedurę , która przyjmie jako paramter ciąg znaków i wypisze go na ekran, ale WIELKIMI LITERAMI. 
PrintUpperCase("Yaaay! Hello world");
static void PrintUpperCase(string input)
{
    Console.WriteLine(input.ToUpper());
}

//Zadanie 11
void PrintConsoleSquare(int x, int y)
{
    //rysujemy pierwszy wiersz
    for(int i = 0; i < x; i++)
        Console.Write("$");
    //schodzimy do nowej linii
    Console.WriteLine();
    //rysujemy srodek (boki)
    for(int i = 0; i < y; i++)
    {
        //lewy bok rysujemy
        Console.Write("$");

        //puste miejsce
        for(int j = 0;j < x - 2; j++)
        {
            Console.Write(" ");
        }

        //prawy bok
        Console.Write("$");
        //zjazd do nowej linii
        Console.WriteLine(" ");
    }
    //dolny wiersz
    for(int i = 0;i < x; i++)
        Console.Write("$");
}
PrintConsoleSquare(5, 5);

//zadanie 12
static string EvenOrOdd1(int number)
{
  string retStr = " ";
    if (number % 2 == 0)
    {
        retStr = "Even";
    }
    else
    {
        retStr = "Odd";
    }
    return retStr;
    
}

//13 zadanie
Console.WriteLine(" ");

int b = 5;
int m = 4;

char[,] tablica = WypełnijTablice(b, m);
WyswietlTabliceNaEkran(tablica);

static char[,] WypełnijTablice(int b, int m)
{
    char[,] tablica = new char[b, m];

    for (int i = 0; i < b; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (i == 0 || i == b - 1 || j == 0 || j == m - 1)
            {
                tablica[i, j] = '#';
            }
            else
            {
                tablica[i, j] = ' ';
            }
        }
    }
    return tablica;
}

// Функция для вывода таблицы на экран
static void WyswietlTabliceNaEkran(char[,] tablica)
{
    int b = tablica.GetLength(0);
    int m = tablica.GetLength(1);

    for (int i = 0; i < b; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(tablica[i, j]);
        }
        Console.WriteLine(); // Переход на новую строку после каждого ряда
    }
}
// Koniec Zadanie 13