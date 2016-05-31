using BuilderPattern.Models;

namespace BuilderPattern.Builders
{
    public class GamingComputerBuilder : ComputerBuilder
    {
        private readonly Computer _computer = new Computer();

        public override void SetComputerType()
        {
            _computer.SetComputerType("Gaming Computer");
        }

        public override void InstallMotherBoard()
        {
            _computer.SetMotherBoard("MSI X99A");
        }

        public override void InstallCpu()
        {
            _computer.SetCpu("Intel i7-6700K");
        }

        public override void InstallGpu()
        {
            _computer.SetGpu("Nvidia 990 GTX");
        }

        public override void InstallRam()
        {
            _computer.SetRam(32);
        }

        public override void InstallPsu()
        {
            _computer.SetPsu(1500);
        }

        public override void InstallDrives()
        {
            _computer.AddDrive("DVD-RW");
            _computer.AddDrive("Blu-Ray-RW");
            _computer.AddDrive("SD");
        }

        public override Computer GetComputer()
        {
            return _computer;
        }
    }
}