/*
Crie uma classe Conta, que representa uma conta bancária com um atributo saldo do tipo float e um atributo criacao do tipo DateTime. 

Em seguida, implemente um atributo chamado numero, que representa o número da conta bancária, e deve ser um número sequencial, gerado automaticamente, a cada vez que uma instância de Conta é criada.

Utilize modificadores de acesso para encapsular todos os atributos de Conta.

Utilize propriedades somente-leitura para acessar o valor do saldo, data de criação e número da conta.

Crie os métodos  para sacar e depositar quantias na conta corrente, conforme as assinaturas: 

public float Sacar(float value) 

public float Depositar(float value) 

 

Finalmente, implemente uma classe MainClass para mostrar o funcionamento da sua classe Conta.*/
using System;

class Conta
{
	private int _id;
	private float _saldo;
	private DateTime _criacao;

	private static int contador;

	public int Id { get => this._id; }
	public float Saldo { get => this._saldo; }
	public DateTime Criacao { get => this._criacao; }

	public Conta(float saldo)
	{
		this._id = ++Conta.contador;
		if (saldo >= 0)
			this._saldo = saldo;
		this._criacao = DateTime.Now;
	}

	public float Sacar(float value)
	{
		if (this._saldo >= value)
		{
			this._saldo = this._saldo - value;
		}
		else
		{
			Console.WriteLine("Saldo insuficiente.");
		}
		return this.Saldo;
	}

	public float Depositar(float value)
	{
		this._saldo = this._saldo + value;
		return this.Saldo;
	}
}

class Program
{
	static void Main()
	{
		Conta[] listaContas = new Conta[5];
		for (int i = 0; i < 5; i++)
		{
			Random rnd = new Random();
			float num = rnd.Next();
			listaContas[i] = new Conta((num));
			Console.WriteLine($"Número da Conta: {listaContas[i].Id}");
			Console.WriteLine($"Saldo da Conta: {listaContas[i].Saldo}");
			Console.WriteLine($"Criação da Conta: {listaContas[i].Criacao}\n");
		}

		Conta contaFonte = new Conta(400);
		Conta contaAlvo = new Conta(100);

		Console.WriteLine("Antes:");
		Console.WriteLine($"\tSaldo Conta Fonte: {contaFonte.Saldo}");
		Console.WriteLine($"\tSaldo Conta Alvo: {contaAlvo.Saldo}");

		float saque = contaFonte.Sacar(200);
		Console.WriteLine($"\nValor do Saque: {saque}");
		contaAlvo.Depositar(saque);


		Console.WriteLine("\nDepois:");
		Console.WriteLine($"\tSaldo Conta Fonte: {contaFonte.Saldo}");
		Console.WriteLine($"\tSaldo Conta Alvo: {contaAlvo.Saldo}");
	}
}