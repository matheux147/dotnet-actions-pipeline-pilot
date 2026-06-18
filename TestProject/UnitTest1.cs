using WebApplication;

namespace TestProject;

public class CalculatorTests { 

    [Fact] 
    public void Sum_ShouldReturnExpectedValue() 
    { 
        var result = Calculator.Sum(2, 3);
        
        Assert.Equal(5, result); 
    } 
}
