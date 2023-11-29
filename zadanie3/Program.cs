
 //Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.


Console.WriteLine("Enter array size");
int size = Convert.ToInt32(Console.ReadLine());
double [] array = new double[size];


void CreateArray(int size){

    Random rand = new Random ();

    for(int i = 0; i<size; i++){
        array[i] = rand.NextDouble() * 100;
        Console.WriteLine($"{array[i]:F2}");
    }
    
}



double Diff(double [] array){

    double min = array[0];
    double max = array[0];
    int i = 1;

    while(i<array.Length){
        if(max<array[i])
        max = array[i];
        if(min>array[i])
        min = array[i];
        i++;
    }

    return max-min;
}




CreateArray(size);
Console.WriteLine($"Разница между максимальным и минимальным числом массива {Diff(array):F2}");


