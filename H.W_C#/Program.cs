// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M\n");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n\n");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

void Numbers (int number1, int number2, int sum){
    sum += number1;
    if(number1 == number2){
        Console.Write(sum);
        return;
    }
    Numbers(number1 + 1, number2, sum);
}
Numbers(m, n, sum);