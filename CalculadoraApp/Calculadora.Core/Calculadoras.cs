namespace Calculadora.Core
{
	public static class Calculadoras
	{
		public  static int Somar(int n1, int n2) => n1 + n2 ;
		public static int Subtrair(int n1, int n2) => n1 - n2;
		public static int Multiplicar(int n1, int n2) => n1* n2;

		public static int Divisao(int n1, int n2)
		{
			if (n2 == 0) throw new 
					Exception("Não é possível dividir por Zero");
			return n1 / n2;
		}
	}
}