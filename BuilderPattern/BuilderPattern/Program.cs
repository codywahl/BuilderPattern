using System;
using BuilderPattern.Builders;
using BuilderPattern.Director;
using BuilderPattern.Models;

namespace BuilderPattern
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var director = new ComputerDirector();

            ComputerBuilder officeComputerBuilder = new OfficeComputerBuilder();
            ComputerBuilder gamingComputerBuilder = new GamingComputerBuilder();

            director.BuildComputer(officeComputerBuilder);
            var officeComputer = officeComputerBuilder.GetComputer();
            Console.WriteLine(officeComputer.ToString());

            director.BuildComputer(gamingComputerBuilder);
            var gamingComputer = gamingComputerBuilder.GetComputer();
            Console.WriteLine(gamingComputer.ToString());

            Console.ReadKey();
        }
    }
}