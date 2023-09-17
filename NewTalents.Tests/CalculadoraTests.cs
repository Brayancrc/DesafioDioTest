using NewTalents;

namespace NewTalents.Tests;


public class CalculadoraTests
{

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (7, 5, 2)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (25, 5, 5)]
    public void TestDividr(int val1, int val2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalculadora = calc.dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestDividirPorZero()
    {
        Calculadora calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(() => calc.dividir(3,0));
    }

    [Fact]
    public void TestHistorico()
    {
        Calculadora calc = new Calculadora();

        calc.somar(1, 2);
        calc.somar(2, 8);
        calc.somar(3, 7);
        calc.somar(4, 1);

        var lista = calc.historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}