using System;

namespace Principles.SOLID.InterfaceSegregation
{
    /*
     * Interface Segregation Principle (ISP)
     *
     * Goal:
     * - Classes should not be forced to implement methods they do not use.
     *
     * How it works:
     * - Instead of one huge worker interface, this demo uses small interfaces:
     *   IPrinter, IScanner, and IFax.
     * - BasicPrinter implements only printing.
     * - MultiFunctionPrinter implements printing, scanning, and faxing.
     *
     * When to use:
     * - Use when interfaces are becoming too broad.
     * - Split interfaces when implementations keep throwing NotSupportedException for unused members.
     *
     * Newbie note:
     * - Small interfaces make classes honest about what they can actually do.
     */
    public static class InterfaceSegregationDemo
    {
        public static void Run()
        {
            Console.WriteLine("Interface Segregation Principle Demo\n");

            IPrinter basicPrinter = new BasicPrinter();
            Console.WriteLine("Step 1: BasicPrinter only needs the IPrinter interface.");
            basicPrinter.Print("Simple report");

            var officeMachine = new MultiFunctionPrinter();
            Console.WriteLine("Step 2: MultiFunctionPrinter can be used through several small interfaces.");
            officeMachine.Print("Contract");
            officeMachine.Scan("Signed contract");
            officeMachine.Fax("Signed contract");
        }
    }

    public interface IPrinter
    {
        void Print(string document);
    }

    public interface IScanner
    {
        void Scan(string document);
    }

    public interface IFax
    {
        void Fax(string document);
    }

    public sealed class BasicPrinter : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"  Printing: {document}");
        }
    }

    public sealed class MultiFunctionPrinter : IPrinter, IScanner, IFax
    {
        public void Print(string document) => Console.WriteLine($"  Printing: {document}");
        public void Scan(string document) => Console.WriteLine($"  Scanning: {document}");
        public void Fax(string document) => Console.WriteLine($"  Faxing: {document}");
    }
}
