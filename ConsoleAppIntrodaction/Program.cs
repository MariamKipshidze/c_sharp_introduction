// See https://aka.ms/new-console-template for more information
namespace ConsoleAppIntrodaction;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Hello, World!");
        Console.WriteLine("I am Learning C#");
        Console.WriteLine(3 + 3);
        Console.WriteLine("Hello " + "World");
        
        InfoPrinter printer = new InfoPrinter();
        printer.PrintInfo();
        
        ConstantVariable myNum = new ConstantVariable();
        myNum.PrintInfo();
        
        TypeCasting typeCasting = new TypeCasting();
        typeCasting.PrintInfo();
    }
}
