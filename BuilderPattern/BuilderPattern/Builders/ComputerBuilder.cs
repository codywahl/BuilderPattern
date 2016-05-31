using BuilderPattern.Models;

namespace BuilderPattern.Builders
{
    public abstract class ComputerBuilder
    {
        public abstract void SetComputerType();

        public abstract void InstallMotherBoard();

        public abstract void InstallCpu();

        public abstract void InstallGpu();

        public abstract void InstallRam();

        public abstract void InstallPsu();

        public abstract void InstallDrives();

        public abstract Computer GetComputer();
    }
}