using System;

class Program
{
    // Cube 過載方法：int 版
    static int Cube(int number)
    {
        return number * number;
    }

    // Cube 過載方法：double 版
    static double Cube(double number)
    {
        return number * number;
    }

    // MinElement：3個 int 參數
    static int MinElement(int a, int b, int c)
    {
        int min = a;

        if (b < min) min = b;
        if (c < min) min = c;

        return min;
    }

    // MinElement：4個 int 參數
    static int MinElement(int a, int b, int c, int d)
    {
        int min = a;

        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;

        return min;
    }

    static void Main(string[] args)
    {
        // 測試 Cube 方法
        Console.WriteLine("Cube(3) = " + Cube(3));           // int 版本
        Console.WriteLine("Cube(2.5) = " + Cube(2.5));       // double 版本

        // 測試 MinElement 方法
        Console.WriteLine("Min of (5, 2, 8) = " + MinElement(5, 2, 8));
        Console.WriteLine("Min of (4, 7, 1, 9) = " + MinElement(4, 7, 1, 9));

        Console.ReadLine(); // 暫停畫面
    }
}
