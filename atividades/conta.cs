/*
Crie uma classe Conta, que representa uma conta bancária com um atributo saldo do tipo float e um atributo criacao do tipo DateTime. 

Em seguida, implemente um atributo chamado numero, que representa o número da conta bancária, e deve ser um número sequencial, gerado automaticamente, a cada vez que uma instância de Conta é criada.

Finalmente, implemente uma classe MainClass para mostrar o funcionamento da sua classe Conta.
*/
using System;

class Conta
{
	public int numero;
	public float saldo;
	public DateTime criacao;

	public static int contador;

	public Conta(float saldo)
	{
		this.numero = ++Conta.contador;
		if (saldo >= 0)
			this.saldo = saldo;
		this.criacao = DateTime.Now;
	}
}

class MainClass
{
	public static void Main()
	{
		Conta[] listaContas = new Conta[5];
		for (int i = 0; i < 5; i++)
		{
			Random rnd = new Random();
			float num = rnd.Next();
			listaContas[i] = new Conta((num));
			Console.WriteLine($"Número da Conta: {listaContas[i].numero}");
			Console.WriteLine($"Saldo da Conta: {listaContas[i].saldo}");
			Console.WriteLine($"Criação da Conta: {listaContas[i].criacao}\n");
		}
	}
}
