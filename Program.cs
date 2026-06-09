using PCBuilderApp.Builders;
using PCBuilderApp.Director;

namespace PCBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerDirector director = new ComputerDirector();

            Console.WriteLine("Building Gaming PC...");
            var gamingBuilder = new GamingPCBuilder();
            var gamingPC = director.Construct(gamingBuilder);
            gamingPC.ShowConfiguration();

            Console.WriteLine("\nBuilding Office PC...");
            var officeBuilder = new OfficePCBuilder();
            var officePC = director.Construct(officeBuilder);
            officePC.ShowConfiguration();
        }
    }
}
