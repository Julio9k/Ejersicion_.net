
namespace ConsoleApp1
{
    public class Areas
    {
        public double Lado { get; set; }

        public double CalculateSquareArea(double LadoLength)
        {
            return Math.Pow(LadoLength, 2);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor del lado del cuadrado:");
            string? inputString = Console.ReadLine();

            if (double.TryParse(inputString, out double LadoValue))
            {
                if (LadoValue >= 0)
                {
                    Areas area = new Areas();
                    double areaResult = area.CalculateSquareArea(LadoValue);
                    Console.WriteLine($"El área del cuadrado con lado {LadoValue} es: {areaResult}");
                }
                else
                {
                    Console.WriteLine("El valor del lado no puede ser negativo. Por favor, ingrese un número válido.");
                }
            }
            else
            {
                Console.WriteLine("Ingrese un número válido para el lado.");
            }
        }
    }

}
