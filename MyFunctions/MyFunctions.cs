using ExcelDna.Integration;

public static class MyUDF
{
    [ExcelFunction(Description = "Returns 10")]
    public static double ReturnTen()
    {
        return 10;
    }
}