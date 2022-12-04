// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

MyMethod my = new MyMethod();
Random rnd = new Random();
CustomArray();


// метод вернёт массив заданной длины и заполнит его случайными числами
int[] RandomArray (){
    int len = my.IntInput();
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++){
        arr[i] = rnd.Next();
    }

    my.PrintArr(arr);
    return arr;
}

// метод читает из консоли числа (сколько угодно), введенные через запятую 
// и возвращает массив типа дабл из них.
double[] CustomArray (){
        Console.WriteLine ("Ожидается цепь чисел, введенных через запятую");
        string[] arr = (Console.ReadLine().Split(", "));
        double[] array = new double[arr.Length];
        for (int i = 0; i < arr.Length; i++){
            array[i] = double.Parse(arr[i]);
        }
        my.PrintArr(array);
        return array;
    
}