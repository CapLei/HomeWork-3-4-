
int [,] Create2dArray(int row, int col, int min, int max){
    int [,] array = new int [row,col];
    for (int i =0; i<row; i++){
        for(int j = 0; j<col;j++){
            array[i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int Show2dSquare(int [,] array){
    int res = 0;
    int min = 0;
    for(int i = 0; i< array.GetLength(0); i++){
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++){
            sum += (array[i, j]);
        }
        if(i == 0){
            min = sum;
            res = i;
        }else if(sum < min){
            min = sum;
            res = i;
        }

    }
    return res;
    
}

Console .WriteLine("Enter row numbers: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter col numbers: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max value: ");
int max = Convert.ToInt32(Console.ReadLine()); 

int [,] created2dArray = Create2dArray(row,col,min,max);
Show2dArray(created2dArray);
int [,] array = created2dArray;


Console.WriteLine("-------------------------");
int res1 = Show2dSquare(array);
Console.WriteLine($"The row with a small sum is equal to {res1}");