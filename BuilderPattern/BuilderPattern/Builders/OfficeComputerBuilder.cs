using BuilderPattern.Models;

namespace BuilderPattern.Builders
{
    public class OfficeComputerBuilder : ComputerBuilder
    {
        private readonly Computer _computer = new Computer();

        public override void SetComputerType()
        {
            _computer.SetComputerType("Office Computer");
        }

        public override void InstallMotherBoard()
        {
            _computer.SetMotherBoard("Generic MotherBoard");
        }

        public override void InstallCpu()
        {
            _computer.SetCpu("Intel i3");
        }

        public override void InstallGpu()
        {
            _computer.SetGpu("Onboard Graphics");
        }

        public override void InstallRam()
        {
            _computer.SetRam(4);
        }

        public override void InstallPsu()
        {
            _computer.SetPsu(750);
        }

        public override void InstallDrives()
        {
            _computer.AddDrive("DVD");
        }

        public override Computer GetComputer()
        {
            return _computer;
        }
    }
}