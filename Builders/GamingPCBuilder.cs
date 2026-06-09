using PCBuilderApp.Models;

namespace PCBuilderApp.Builders
{
    public class GamingPCBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void BuildCPU()
        {
            _computer.CPU = "Intel i9";
        }

        public void BuildGPU()
        {
            _computer.GPU = "NVIDIA RTX 5090";
        }

        public void BuildRAM()
        {
            _computer.RAM = "32GB DDR5";
        }

        public void BuildStorage()
        {
            _computer.Storage = "2TB NVMe SSD";
        }

        public void BuildMotherboard()
        {
            _computer.Motherboard = "ASUS ROG";
        }

        public void BuildPowerSupply()
        {
            _computer.PowerSupply = "1000W Gold";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}
