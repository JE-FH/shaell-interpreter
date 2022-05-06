using Xunit;

namespace ShaellLang.Test;

public class UnitTest
{
    [Fact]
    public void TestOperators()
    {
        ShaellLang shaellLang = new ShaellLang();
        shaellLang.LoadTestLib();
        
        shaellLang.RunFile("../../../OperatorTest.æ");
    }
    
    [Fact]
    public void TestMetaTables()
    {   
        ShaellLang shaellLang = new ShaellLang();
        shaellLang.LoadTestLib();

        shaellLang.RunFile("../../../MetatableTest.æ");
    }

    [Fact]
    public void TestStringInterpolation()
    {
        ShaellLang shaellLang = new ShaellLang();
        shaellLang.LoadTestLib();

        shaellLang.RunFile("../../../StringInterpolationTest.æ");
    }
    
    [Fact]
    public void TestScope()
    {
        ShaellLang shaellLang = new ShaellLang();
        shaellLang.LoadTestLib();

        shaellLang.RunFile("../../../ScopeTest.æ");
    }

    [Fact]
    public void TestForeach()
    {
        ShaellLang shaellLang = new ShaellLang();
        shaellLang.LoadTestLib();
        
        shaellLang.RunFile("../../../ForeachTest.æ");
    }
    
    [Fact]
    public void TestTryThrow()
    {
        ShaellLang shaellLang = new ShaellLang();
        shaellLang.LoadTestLib();

        shaellLang.RunFile("../../../TryThrowTest.æ");
    }

    [Fact]
    public void TestTypeSystem()
    {
        ShaellLang shaellLang = new ShaellLang();
        shaellLang.LoadTestLib();
        
        shaellLang.RunFile("../../../TypeSystemTest.æ");
    }
    
    [Fact]
    public void TestDeref()
    {
        ShaellLang shaellLang = new ShaellLang();
        shaellLang.LoadTestLib();
        
        shaellLang.RunFile("../../../DerefTest.æ");
    } 

    [Fact]
    public void TestFileOperations()
    {
        ShaellLang shaellLang = new ShaellLang();
        shaellLang.LoadTestLib();
        
        shaellLang.RunFile("../../../FileOperationsTest.æ");
    }

    [Fact]
    public void TestWhitespace()
    {
        ShaellLang shaellLang = new ShaellLang();
        shaellLang.LoadTestLib();

        shaellLang.RunFile("../../../WhitespaceTest.æ");
    }
}