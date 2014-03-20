using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_union_intersection
{
	class Program
	{

		static void Main(string[] args)
		{
			List<int> ListaA;
			List<int> ListaB;
			ListaA = new List<int>(){3, 5, 7, 8, 9};
			ListaB = new List<int>(){2, 7, 9};

			Console.Write("A = ");
			foreach (int elemento in ListaA)
				Console.Write(elemento + ", ");
			Console.WriteLine();

			Console.Write("B = ");
			foreach (int elemento in ListaB)
				Console.Write(elemento + ", ");
			Console.WriteLine();
			Console.WriteLine();


			Console.Write("C = A U B = ");
			foreach (int elemento in union(ListaA, ListaB))
				Console.Write(elemento + ", ");
			Console.WriteLine();

			Console.Write("D = A + B = ");
			foreach (int elemento in suma(ListaA, ListaB))
				Console.Write(elemento + ", ");
			Console.WriteLine();

			Console.Write("E = A intersection B = ");
			foreach (int elemento in interseccion(ListaA, ListaB))
				Console.Write(elemento + ", ");
			Console.WriteLine();


		}

		static List<int> union(List<int> A, List<int> B)
		{
			List<int> C = new List<int>() { };

			C = A;
			C.AddRange(B);
			C.Sort();

			int size = C.Count-1;
			for (int i = 0; i < size; i++)
			{
				if (C[i] == C[i + 1])
				{
					C.RemoveAt(i + 1);
					size--;
				}
			}

			return C;
		}


		static List<int> suma(List<int> A, List<int> B)
		{
			List<int> C = new List<int>() {};

			foreach (int elementoA in A)
				C.Add(elementoA);
			foreach (int elementoB in B)
				C.Add(elementoB);

			C.Sort();

			return C;
		}

		static List<int> interseccion(List<int> A, List<int> B)
		{
			List<int> C = new List<int>() { };

			for (int i = 0; i < A.Count; i++)
			{
				for (int j = 0; j < B.Count; j++)
				{
					if (A[i] == B[j])
					{
						C.Add(A[i]);
					}
				}
			}

			return C;
		}

		static List<int> diferencia(List<int> A, List<int> B)
		{
			List<int> C = new List<int>() { };

			for (int i = 0; i < A.Count; i++)
			{
				for (int j = 0; j < B.Count; j++)
				{
					if (A[i] == B[j])
					{
						C.Add(A[i]);
					}
				}
			}

			return C;
		}
	}
}
