using BuilderPattern.Builders;

namespace BuilderPattern.Director
{
    public class ComputerDirector
    {
        public void BuildComputer(ComputerBuilder builder)
        {
            builder.SetComputerType();
            builder.InstallMotherBoard();
            builder.InstallCpu();
            builder.InstallGpu();
            builder.InstallRam();
            builder.InstallDrives();
            builder.InstallPsu();
        }
    }
}