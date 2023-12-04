int [] CreateArray(int min, int max, int size){

    int [] array = new int [size];
    for(int i = 0; i<size; i++){
        array[i] = new Random().Next(min, max+1);
    }
    return array; 
}

void ShowArray(int [] array){
    
    for(int i = 0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

void FindDigit(int[] array){
    int temp = 0;
    for(int i = 0, j = array.Length - 1; i <= j; i++, j--){
        temp = array[i];
       array[i] = array[j];
       array[j] = temp;
        
        Console.WriteLine();
    }
   /* ShowArray(array); */
}


Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter array max");
int max = Convert.ToInt32(Console.ReadLine());

int [] array = CreateArray(min, max, size);
ShowArray(array);
FindDigit(array);
ShowArray(array);
Console.WriteLine();

