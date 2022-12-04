// Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и 
// метод который возводит число A в натуральную степень B. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. 
// Не использовать Math.Pow()


MyMethod my = new MyMethod();   // чтобы было проще читать код (на самом деле, чтобы можно было перегружать методы)
                                // я вынес свои методы (не относящиеся к решению) в отдельный класс

double number = my.DoubleInput();

double degree = my.DoubleInput();

double res = exponentiation(number, degree);

my.DebugString("Результат выполнения: ", res);

//TestExponentiation();  // вызов тестового метода

// тестовый метод
void TestExponentiation (){
    double[] request = new double[] {-5, -1, 0, 1, 5};
    double[] requestDeg = new double[] {-3, -1, 0, 1, 3};
    double[,] responce = new double[request.Length,requestDeg.Length];
    bool test;
    int raws = responce.GetUpperBound(0)+1;
    int columns = responce.Length / raws;
    for (int i = 0; i < raws; i++){
        for (int j =0; j < columns; j++){
            responce[i,j] = Math.Pow(request[i], requestDeg[j]);    // Я думаю, использование Pow в этом контексте -
            // не будет считаться нарушением. Было бы странным, проверять свой метод с его же помощью. 
            // А вручную считать степени - это что-то очень страшное >_<
        }
    }
    my.Print("Проверочная таблица:"); 
    my.PrintArr(responce);              // это отладочная информация, здесь немного новый синтаксис в массивах
                                        // я должен был убедиться, что всё работает как мне нужно
    for (int i = 0; i<raws; i++){
        for (int j = 0; j < columns; j++){
            if (exponentiation(request[i], requestDeg[j]) == responce[i,j]){
                test = true;
            } else {
                test = false;
            }
            my.DebugString($"запрос:{request[i]}^{requestDeg[j]} | ожидается:{responce[i,j]} | результат:{exponentiation(request[i], requestDeg[j])}", test);
        }   // в этот момент я понял, что зря заморачивался с перегрузкой методов печати. Хватило бы интерполяции в методе my.Print.
    }
}


// собственно, рабочий метод:
double exponentiation (double num, double degree){
    if (num == 0) {
        if (degree == 0) return 1;
        if (degree < 0) {
        my.Print("0 нельзя возвести в отрицательную степень");  // здесь по-хорошему, нужно выкинуть исключение, но я 
        // не разобрался пока с местным Throw
        }
        return 0;
    }

    if (num == 1) return 1;
    
    if (degree == 1) return num;
    
    if (degree == 0) return 1;
    
    if (degree > 0) {
        int tempDegree = 1;
        double exp = num;
        while (tempDegree < degree) {
            exp = exp * num;
            tempDegree++;
        }
        return exp;
    } else {
        return (1 / (exponentiation (num, my.Md(degree))));
    }
}