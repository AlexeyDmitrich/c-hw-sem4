class MyMethod {

    public int IntInput (){
        Console.WriteLine ("Ожидается целое число");
        bool isInt = int.TryParse((Console.ReadLine()), out int num);
        if (! isInt){
            Console.WriteLine ("Недопустимый тип данных");
            return IntInput();
        } else {
            return num;
        }
    }

    public double DoubleInput (){
        Console.WriteLine ("Ожидается вещественное число");
        bool isDouble = double.TryParse((Console.ReadLine()), out double num);
        if (! isDouble){
            Console.WriteLine ("Недопустимый тип данных");
            return DoubleInput();
        } else {
            return num;
        }
    }

    public void Print (string text){
        Console.WriteLine(text);
    }


    public void PrintArr (int[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        }
    public void PrintArr (double[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
        }
    public void PrintArr (int[,] array){
        int rows = array.GetUpperBound(0)+1;
        int columns = array.Length / rows;
        for(int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public void PrintArr (double[,] array){
        int rows = array.GetUpperBound(0)+1;
        int columns = array.Length / rows;
        for(int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public int Md (int num){
        if (num > 0){
            return num;
        } else {
            return (num * -1);
        }
    }
    public double Md (double num){
        if (num > 0){
            return num;
        } else {
            return (num * -1);
        }
    }
}
