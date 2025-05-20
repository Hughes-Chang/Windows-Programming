using System;

// 定義 IPrice 介面
interface IPrice
{
    double GetPrice();
}

// 定義 Car 類別，實作 IPrice 介面
class Car : IPrice
{
    public double price;
    public string Name;

    public Car(string name, double price)
    {
        this.Name = name;
        this.price = price;
    }

    public double GetPrice()
    {
        return price;
    }

    public string GetName()
    {
        return Name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 建立 Car 物件
        Car myCar = new Car("Toyota Corolla", 750000);

        // 顯示車名與價格
        Console.WriteLine("車名：" + myCar.GetName());
        Console.WriteLine("價格：" + myCar.GetPrice() + " 元");

        Console.ReadLine(); // 防止執行完馬上關閉
    }
}
