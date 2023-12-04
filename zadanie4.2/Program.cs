int [] CreateArray(int size){

    int [] array = new int [size];
    for(int i = 0; i<size; i++){
        array[i] = new Random().Next(100, 999);
    }
    return array; 
}

void ShowArray(int [] array){
    
    for(int i = 0; i<array.Length;i++){
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}


int FindDigit(int[] array, int result){
   result = 0;
    for(int i = 0; i<array.Length; i++){
    
        if(array[i] % 2 == 0){
           
           result++;
            
        }
    }
    return result;
}


Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());

int result=0;
int [] array = CreateArray(size);
ShowArray(array);
int res = FindDigit(array, result);
Console.WriteLine(res);