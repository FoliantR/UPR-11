using ConsoleApp1;

namespace Template 
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Strategy<LaserPrinter> laserPrint = 
                new Strategy<LaserPrinter>(new LaserPrinter("Asus","B-3355"));
            laserPrint.print();
            Strategy<MatrixPrinter> matrixPrint =
                new Strategy<MatrixPrinter>(new MatrixPrinter("Samsung", "ZUR-5"));
            matrixPrint.print();
        }
    }
}
