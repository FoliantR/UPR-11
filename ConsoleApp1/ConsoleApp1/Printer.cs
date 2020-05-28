using System;

namespace Template
{
    class Printer
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public Printer(string name, string model)
        {
            Name = name;
            Model = model;
        }
        public string GetName()
        {
            return $"Имя: {Name}, Модель: {Model}";
        }
        public virtual void work()
        {
            Console.WriteLine("Ничего...");
        }
    }
}
