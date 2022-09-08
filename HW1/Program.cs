using System;

public class Program {

static void Main(string[] args) {
    Console.Write("Please input Name : ");
    var Name = Console.ReadLine();
    Console.Write("Please input Number : ");
    var Number = int.Parse(Console.ReadLine());
    Console.Write("Please input Owner Name : ");
    var OwnerName = Console.ReadLine();
    Console.Write("Please input Registered Value : ");
    var RegisteredValue = int.Parse(Console.ReadLine());
    Store store = new Store(Name,Number,OwnerName,RegisteredValue);
    store.PrintStoreInformation();

    Console.Write("Please input money : ");
    var money = Console.ReadLine();
    Store store1 = new Store(money);
    store1.PrintMoneyInformation();
 }


}