using PCBuilderApp.Models;

namespace PCBuilderApp.Builders
{
    public interface IComputerBuilder
    {
        void BuildCPU();
        void BuildGPU();
        void BuildRAM();
        void BuildStorage();
        void BuildMotherboard();
        void BuildPowerSupply();

        Computer GetComputer();
    }
}
