using System;
public class intergerTest
{
    static void Main(string[] args)
    {
        int a=10, b=20, x=5, y=2 ;
        int g1, g2, g3, g4, g5, g6, g7, g8, g9, g10;
        g1=a + b;
        g2= x - b;
        g3= x * b;
        g4= y / a;
        g5= b % y;
        g6= y + 10 % x;
        g7= a / 3 * 5;
        g8= 9 / 2 * a;
        g9= y % 8;
        g10= 100 * x + y % 2 - a;

        Console.WriteLine(" 1={0}, 2={1}, 3={2}, 4={3}, 5={4}", g1, g2, g3, g4, g5 );
        Console.WriteLine(" 6={0}, 7={1}, 8={2}, 9={3}, 10={4}", g6, g7, g8, g9, g10);
    }
}
