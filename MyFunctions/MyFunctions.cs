using ExcelDna.Integration;

public static class TestUDF
{
    [ExcelFunction(Description="Returns 123")]
    public static double Test()
    {
        return 123;
    }
}