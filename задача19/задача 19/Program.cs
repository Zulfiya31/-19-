// определить плилиндром.
Console.WriteLine("Введите пятизначное число ");
double a = double.Parse(Console.ReadLine());
double s = a%100;
double b = (a%1000);
double c = (a-b)/1000;
double f = c%10*10;
double e = c%100;
double x = e%10;
double r = (e-x)/10;
double v = f+r;
if(v==s){
    Console.WriteLine(a + "=> да");
}
if((v<s)&&(v>s)){
    Console.WriteLine(a + "=> нет");
}
         
