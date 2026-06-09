using PCBuilderApp.Builders;
using PCBuilderApp.Models;

namespace PCBuilderApp.Director
{
    public class ComputerDirector
    {
        public Computer Construct(IComputerBuilder builder)
        {
            builder.BuildCPU();
            builder.BuildGPU();
            builder.BuildRAM();
            builder.BuildStorage();
            builder.BuildMotherboard();
            builder.BuildPowerSupply();

            return builder.GetComputer();
        }
    }
}
