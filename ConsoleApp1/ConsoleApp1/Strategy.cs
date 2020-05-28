using Template;

namespace ConsoleApp1
{
    class Strategy<TPrinter>
        where TPrinter : Printer
    {
        TPrinter _printer;
        public Strategy(TPrinter newPrint)
        {
            _printer = newPrint;
        }
        public void print()
        {
            _printer.work();
        }
    }
}
