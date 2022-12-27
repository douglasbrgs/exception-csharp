namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }
            catch (FormatException)
            {
                Console.WriteLine("A string de entrada não estava no formato correto.");
            }
        }
    }
}