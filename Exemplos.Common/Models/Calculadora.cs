namespace Exemplos.Common.Calculadora
{
  public class Calculadora
  {


    public void soma(int numero1, int numero2)
    {
      Console.WriteLine($"{numero1} + {numero2} = " + (numero1 + numero2));

    }

    public void subtracao(int numero1, int numero2)
    {
      Console.WriteLine($"{numero1} - {numero2} = " + (numero1 - numero2));

    }


    public void divisao(int numero1, int numero2)
    {
      Console.WriteLine($"{numero1} / {numero2} = " + (numero1 / numero2));

    }


    public void multiplicacao(int numero1, int numero2)
    {
      Console.WriteLine($"{numero1} X {numero2} = " + (numero1 * numero2));

    }

    public void raiz(int numero1)
    {
      Console.WriteLine($"A raiz quadrada de {numero1} = " + (Math.Sqrt(numero1)));

    }


    public void exponeciacao(int numero1, int numero2)
    {
      Console.WriteLine($"{numero1} Elevado a  {numero2} = " + (Math.Pow(numero1, numero2)));

    }

  }
}