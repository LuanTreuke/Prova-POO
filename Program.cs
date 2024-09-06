using System.Security.Cryptography.X509Certificates;

namespace Prova_POO;

class Program
{
	static void Main(string[] args)
	{
		Stack<string> pilhaLivros = new Stack<string>();
		
		bool isEmpty = false;
		
		pilhaLivros.Push("O senhor dos Anéis");
		pilhaLivros.Push("Harry Potter");
		pilhaLivros.Push("O Hobbit");
		
		Console.WriteLine("Livro no topo da pilha: " + pilhaLivros.Peek());
		
		Console.WriteLine("Livro Removido: " + pilhaLivros.Pop());
		
		Console.WriteLine("Livro no topo da pilha: " + pilhaLivros.Peek());
		
		if (isEmpty == false)
		{
			Console.WriteLine("Pilha de livros após remoção: ");
			foreach (string livro in pilhaLivros)
			{
				Console.WriteLine(livro);
			}
		}
		else
		{
			Console.WriteLine("Pilha vazia.");
		}
	}
}
