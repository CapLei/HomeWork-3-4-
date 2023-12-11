

string CreateStringArray(char[,] array){
    string res ="";
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            res += array[i,j];
        }
    }
    return res;
}



char[,] array = new char[,] { {'a','b'} , {'c','d'} };
string result = CreateStringArray(array);
Console.WriteLine(result);
