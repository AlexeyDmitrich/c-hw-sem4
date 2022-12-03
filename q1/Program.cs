


// расчет модуля числа для работы с отрицательными вводными
int Md (int num){
    if (num >= 0){
        return num;
    } else {
        return (num * (-1));
    }
}

// определение числа знаков в числе (для построения массива)
int SecNum (int num) {    // принимает целое число и число для поиска
    int range = 0;
    int tempToRange = Md(num);  // временный дубликат числа для определения разряда
    while (tempToRange != 0){
        tempToRange = tempToRange / 10;
    //  Console.WriteLine($"Уменьшенное число {search}");
        range++;
    //  Console.WriteLine($"Предполагаемый разряд {range}");
    }
    return range;
}
