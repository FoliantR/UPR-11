using System;

namespace Template
{
    class LaserPrinter : Printer
    {
        public LaserPrinter(string name, string model) : base(name, model)
        {
            Name = name;
            Model = model;
        }
        public override void work()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Лазерный принтер {Name} {Model} что то напечатал..\n");
            Console.ResetColor();
        }
    }
}
