using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraBasicaTests
{
    private CalculadoraBasica _calculadora;

    public CalculadoraBasicaTests()
    {
        _calculadora = new CalculadoraBasica();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(1, 8, 9)]
    [InlineData(11, 12, 23)]
    [InlineData(15, 16, 31)]
    [InlineData(2, -4, -2)]
    public void TestarSomar(int valor1, int valor2, int resultadoEsperado)
    {
        int resultado = _calculadora.Somar(valor1, valor2);

        Assert.Equal(resultadoEsperado, resultado);
    }
    
    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(11, 8, 3)]
    [InlineData(32, 12, 20)]
    [InlineData(15, -16, 31)]
    [InlineData(-2, 0, -2)]
    public void TestarSubtrair(int valor1, int valor2, int resultadoEsperado)
    {
        int resultado = _calculadora.Subtrair(valor1, valor2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(5, 8, 40)]
    [InlineData(11, 12, 132)]
    [InlineData(15, 16, 240)]
    [InlineData(2, -4, -8)]
    public void TestarMultiplicar(int valor1, int valor2, int resultadoEsperado)
    {
        int resultado = _calculadora.Multiplicar(valor1, valor2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, 0)]
    [InlineData(0, 3, 0)]
    [InlineData(11, 5, 2)]
    [InlineData(15, 3, 5)]
    [InlineData(24, -4, -6)]
    public void TestarDividir(int valor1, int valor2, int resultadoEsperado)
    {
        int resultado = _calculadora.Dividir(valor1, valor2);

        Assert.Equal(resultadoEsperado, resultado);
    }

    [Theory]
    [InlineData(1, 2, 1)]
    [InlineData(12, 8, 4)]
    [InlineData(11, 3, 2)]
    [InlineData(15, 5, 0)]
    [InlineData(23, 4, 3)]
    public void TestarCalcularResto(int valor1, int valor2, int resultadoEsperado)
    {
        int resultado = _calculadora.CalcularResto(valor1, valor2);

        Assert.Equal(resultadoEsperado, resultado);
    }
}