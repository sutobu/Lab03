//1 zadanie
int n = 0;
do
{
    Console.WriteLine(n) ; 
    n++ ;
}  while (n < 11);


//2 zadanie
string password = "";
do
{
    Console.WriteLine("podaj haslo :) ");
    password = Console.ReadLine();
} while (password != "a");

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

int[,] m = new int[3,4];
int value = 1;
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        m[i,j] = value;
        value++;
    }
}
Console.WriteLine("Macierz po transpozycji:");
for (int i = 0;i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine(m[i,j] + " ");
    }
    Console.WriteLine();
}

