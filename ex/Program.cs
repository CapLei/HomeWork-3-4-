bool v = true;
while(v){
    Console.WriteLine("Enter your number"); 
    if (Console.ReadLine()==("q")){
       v = false;
       break;
    }else{
    void Esc2(int number){
    int num =number;
    int res = 0 ;
    while(num>0){
     res= res + num%10;
    num/=10;
    }
    if(res%2==0){
    v = false;
    }
  }
     int number = Convert.ToInt32(Console.ReadLine()); 
  Esc2(number);
 }
    

    

    
}



/* 
void Esc2(int number){
    int num =number;
    int res = 0 ;
    while(num>0){
        res= res + num%10;
        num/=10;
    }
    if(res%2==0){
        v = false;
    }
} */