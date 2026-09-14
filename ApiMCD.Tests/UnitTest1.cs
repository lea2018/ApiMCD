namespace ApiMCD.Tests;

public class CalentamientoTests
{
    [Fact]
    public void Sumar_DosNumeros_DebeRetornarResultadoCorrecto()
    {
        // Arrange
        var a = 10;
        var b = 20;

        // Act
        var resultado = a + b;

        // Assert
        Assert.Equal(30, resultado);
    }
}