using PCBuilderApp.Models;

namespace PCBuilderApp.Builders
{
    public class OfficePCBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void BuildCPU()
        {
            _computer.CPU = "Intel i5";
        }

        public void BuildGPU()
        {
            _computer.GPU = "Integrated Graphics";
        }

        public void BuildRAM()
        {
            _computer.RAM = "16GB DDR4";
        }

        public void BuildStorage()
        {
            _computer.Storage = "512GB SSD";
        }

        public void BuildMotherboard()
        {
            _computer.Motherboard = "Gigabyte B660";
        }

        public void BuildPowerSupply()
        {
            _computer.PowerSupply = "500W";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}
