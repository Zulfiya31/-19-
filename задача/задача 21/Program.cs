// See https://aka.ms/new-console-template for more information
int x1 = 3;
int y1 = 6;
int z1 = 8;
int x2 = 2;
int y2 = 1;
int z2 = -7;
double t1= Math.Pow(x2-x1,2);
double t2= Math.Pow(y2-y1,2);
double t3= Math.Pow(z2-z1,2);
double res = Math.Sqrt(t1+t2+t3);
Console.WriteLine ( "A"+ "("+x1 +"," +y1+","+z1+","+")" +"B"+ "("+x2+","+y2+","+z2+","+ ")" +"=>"+ res);