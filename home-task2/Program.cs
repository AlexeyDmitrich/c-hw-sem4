// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

MyMethod my = new MyMethod();   // аналогично первой задаче, но есть нюансы:
/*
Проблема заключается в том, что я так и не смог создать класс в директории c-hw-sem4, 
чтобы его было видно из проектов во вложенных директориях. 
Хотелось бы разобраться, насколько это возможно.
*/


int number = my.IntInput();

int sumNumsInNumber = SumNums(number);
my.Print($"Сумма всех цифр числа {number} равна {sumNumsInNumber}");

// TestSumNums();    // Точка входа в тестовый метод

void TestSumNums (){
    int[] request = new int[]{452, 82, 9012, 11111, 15158};
    int[] response = new int[]{11, 10, 12, 5, 20};
    for (int i = 0; i < request.Length; i++){
        if (SumNums(request[i]) == response[i]){
            my.Print($"Тест {i+1} пройден успешно");
        } else {
            my.Print($"Тест {i+1} провален");
        }
    }
}

int SumNums (int userNumber){
    int res = 0;
    if (userNumber > 0){
        while (userNumber > 0){
            int temp = userNumber%10;
            res += temp;
            userNumber = (userNumber - temp)/10;
        }
    } else {
        return SumNums(my.Md(userNumber));
    }
    return res;
}