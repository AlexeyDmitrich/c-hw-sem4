bool usersNumber = int.TryParse(Console.ReadLine(), out int number);
    if (!(usersNumber)){
        Console.WriteLine("Вы ввели чё-то не то");
        return;
    }
    else{
        // добавить вызов главного метода
        //TestCountOfSimpleNumsToUserNum();
        int count = CountOfSimpleNumsToUserNum(number);
        Console.WriteLine ($"До введённого значения найдено {count} простых чисел");        
    }

void TestCountOfSimpleNumsToUserNum (){
    int[] request =  new int[]{2, 3, 11 , 29, 179, 383, 999};
    int[] response = new int[]{0, 1, 4,   9, 40,  75, 168};
    
    for (int i = 0; i < request.Length; i++){
        int methodOut = CountOfSimpleNumsToUserNum(request[i]);
        if (methodOut == response[i]){
            Console.WriteLine($"Ожидаемое значение {response[i]} подтверждено результатом {methodOut}");
        } else {
            Console.WriteLine($"Ожидаемое значение {response[i]} противоречит результату {methodOut}");
        }
    }
}

int CountOfSimpleNumsToUserNum (int userNum){
    int n = userNum;
    int counter = 0;
    int[] allNums = new int[userNum];
    for (int i = 2; i < allNums.Length; i++){
        allNums[i]=i;
    }
    for (int i = 2; i < allNums.Length-2; i++){
    //    Console.WriteLine($"Ячейка {i}");
        if (allNums[i] != 0){
            allNums[i] = i;
            Console.WriteLine($"Ячейка {i} обрабатывается");
            for (int j = (i + i); j < (allNums.Length); j+=i){
                allNums[j] = 0;
                Console.WriteLine($"Ячейка {j} : {allNums[j]}");
            }
        //    i++;
        }
        else {
        Console.WriteLine($"Ячейка {i} пропускается");
        //     i++;
        }
        
    }
    PrintArr(allNums);
    
    for(int i = 0; i < allNums.Length; i++){
        if (allNums[i] > 0){
        counter++;
        }
    }
    return counter;
}

void PrintArr (int[] array){
    for(int i = 0; i < array.Length; i++){
        if (array[i] > 0){
        Console.Write($"{array[i]} ");
        }
    }
    Console.WriteLine();
}