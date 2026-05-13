using ExcelDna.Integration;

namespace MyFunctions
{
    public static class UDFs
    {
        [ExcelFunction(Description = "Add two numbers")]
        public static double MyAdd(double a, double b) => a + b;

        [ExcelFunction(Description = "Multiply two numbers")]
        public static double MyMultiply(double a, double b) => a * b;

        [ExcelFunction(Description = "Return a greeting string")]
        public static string SayHello(string name) => $"Hello, {name}!";
    }
}