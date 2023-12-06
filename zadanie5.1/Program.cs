

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

void Show2dSquare(int [,] array, int row1, int col1){
    if(row1 > array.GetLength(0)-1 && col1 > array.GetLength(1)-1){
        Console.WriteLine("Erorr");
    }else{
        Console.WriteLine(array[row1-1, col1-1]);
    }
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


Console.WriteLine("Check the element in the array");
Console.WriteLine("Enter your row number");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your col number");
int col1 = Convert.ToInt32(Console.ReadLine());
Show2dSquare(array, row1, col1);