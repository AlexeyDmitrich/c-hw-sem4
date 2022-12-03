// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4->24 5->120

Console.WriteLine("Введите число");
bool usersNumber = int.TryParse(Console.ReadLine(), out int number);
    if (!(usersNumber)){
        Console.WriteLine("Вы ввели чё-то не то");
        return;
    }
    else{
        int factorial = Factorial(number);
    }
Console.WriteLine($"Факториал числа {number} равен {Factorial(number)}");


void Test() {

int[] numbers = new int[] {  4 , 5};

int[] sums = new int[] { 24 , 120 };

for (var i = 0; i < numbers.Length; i++)
{
    int sum = Factorial(numbers[i]);

    if (sum != sums[i])
    {
        Console.WriteLine($"Ожидали получить {sums[i]} а получили {sum}");
    }
    else
    {
        Console.WriteLine($"Ожидаемый результат:{sums[i]} Фактический результат:{sums[i]}");
    }
}
}

int Factorial (int number){
    if ((number == 0) || (number == 1)){
        return 1;
    }
    return number*(Factorial (number-1));
}