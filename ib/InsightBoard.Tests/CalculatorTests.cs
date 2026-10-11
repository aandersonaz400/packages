using InsightBoard.Core;

public class CalculatorTests {
    private readonly Calculator calc = new();

    [Fact] public void Add_ReturnsCorrectSum() =>
        Assert.Equal(5, calc.Add(2, 3));
    [Fact] public void Subtract_ReturnsCorrectDifference() =>
        Assert.Equal(1, calc.Subtract(3, 2));
    [Fact] public void Multiply_ReturnsCorrectProduct() =>
        Assert.Equal(12, calc.Multiply(3, 4));
    [Fact] public void Divide_ReturnsCorrectQuotient() =>
        Assert.Equal(5.0, calc.Divide(10, 2));
    [Fact] public void Divide_ByZero_ThrowsException() =>
        Assert.Throws<DivideByZeroException>(
            () => calc.Divide(10, 0));
    [Fact] public void Percentage_ReturnsCorrectValue() =>
        Assert.Equal(25.0, calc.Percentage(50, 200));
    [Fact] public void Percentage_ByZeroTotal_ThrowsException() =>
        Assert.Throws<DivideByZeroException>(
            () => calc.Percentage(10, 0));
}
