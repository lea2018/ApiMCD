using ApiMCD.Services;

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

    [Fact]
    public void MCD_48Y18_DebeRetornar6()
    {
        // Arrange
        var service = new MCDService();

        // Act
        var resultado = service.CalcularMCD(48, 18);

        // Assert
        Assert.Equal(6, resultado);
    }

    [Fact]
    public void MCD_100Y25_DebeRetornar25()
    {
        // Arrange
        var service = new MCDService();

        // Act
        var resultado = service.CalcularMCD(100, 25);

        // Assert
        Assert.Equal(25, resultado);
    }
}