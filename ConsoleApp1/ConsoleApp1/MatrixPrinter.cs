using System;

namespace Template
{
    class MatrixPrinter : Printer
    {
        public MatrixPrinter(string name, string model):base(name, model)
        {
            Name = name;
            Model = model;
        }
        public override void work()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"Матричный принтер {Name} {Model} ") ;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("что-то напечатал\n");
            Console.ResetColor();
        }
    }
}
