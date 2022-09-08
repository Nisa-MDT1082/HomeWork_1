public class Store {
    public string Name;
    public int Number;
    public string OwnerName;
    public int RegisteredValue;
    public double thousand, fiveHundred, oneHundred, fifthy, twenty, ten, two, one, pointfifty, pointtwentyfive;
    public string moneyvalue;


    public Store(string moneyvalue){
        this.moneyvalue = moneyvalue;
    }

    public Store(string Name, int Number, string OwnerName,int RegisteredValue) {
        this.Name = Name;
        this.Number = Number;
        this.OwnerName = OwnerName;
        this.RegisteredValue = RegisteredValue;
    }

    
    public void PrintStoreInformation() {
    Console.WriteLine("*********** Shop Information ***************");
    Console.WriteLine("Name : {0}", Name);
    Console.WriteLine("Number : {0}", Number);
    Console.WriteLine("Owner Name : {0}", OwnerName);
    Console.WriteLine("Registered Value : {0}", RegisteredValue);
    Console.WriteLine("********************************************");
 }

 public void PrintMoneyInformation() {
    Console.WriteLine("*********** Money Information ***************");
     string[] partstring = moneyvalue.Split('.');
        int front = CheckTypeInterger(partstring[0]);
        int decemalpart = CheckTypeDecemal(partstring[1]);
        if(SpecialDecimal(decemalpart)) decemalpart *= 100;
        if(CheckInteger(front) && 
            CheckDecimal(decemalpart) && 
            SpecialDecimal(decemalpart)) 
            throw new Exception("Wrong!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
        else {
            Calculater(front, decemalpart);
            PrintCalculator();
        }
    Console.WriteLine("********************************************");
    }

    public int ChangeTypeInt(string front){
        if(int.TryParse(front, out int num)){
            return num;
        }
        else{
            throw new Exception("Not Interger");
        }
    }

    public int CheckTypeInterger(string front){
        if(int.TryParse(front, out int num)){
            return num;
        }
        else{
            throw new Exception("Not Interger");
        }
    }

    public int CheckTypeDecemal(string decemalpart){
        if(int.TryParse(decemalpart, out int num)){
            return num;
        }
        else{
            throw new Exception("Not Decemal");
        }
    }

    public bool CheckInteger(int front){
        if(front > 0){
            return false;
        }
        
        return true;
    }

    public bool CheckDecimal(int behind){
        if(behind >= 25 && behind != 50 && behind <= 75){
            return false;
        }
        
        return true;
    }

    public bool SpecialDecimal(int behind){
        if(behind >= 1 && behind <= 9){
            return true;
        }
        return false;
    }

    public void Calculater(int front, int behind){
        thousand = front / 1000;
        front %= 1000;
        fiveHundred = front / 500;
        front %= 500;
        oneHundred = front / 100;
        front %= 100;
        fifthy = front / 50;
        front %= 50;
        twenty = front / 20;
        front %= 20;
        ten = front / 10;
        front %= 10;
        two = front / 2;
        front %= 2;
        one = front / 1;
        front %= 1;
        pointfifty = behind / 50;
        behind %= 50;
        pointtwentyfive = behind / 25;
        behind %= 25;
    }

    public void PrintCalculator(){
        Console.WriteLine("1000 : {0}" ,thousand);
        Console.WriteLine("500  : {0}" ,fiveHundred);
        Console.WriteLine("100  : {0}" ,oneHundred);
        Console.WriteLine("50   : {0}" ,fifthy);
        Console.WriteLine("20   : {0}" ,twenty);
        Console.WriteLine("10   : {0}" ,ten);
        Console.WriteLine("5    : {0}" ,two);
        Console.WriteLine("1    : {0}" ,one);
        Console.WriteLine("0.50 : {0}" ,pointfifty);
        Console.WriteLine("0.25 : {0}" ,pointtwentyfive);
    }
}