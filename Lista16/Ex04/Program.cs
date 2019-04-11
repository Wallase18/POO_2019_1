using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    class Pais : IComparable
    {
        private string nome;
        private int ouro, prata, bronze;
        public Pais(string n, int o, int p, int b)
        {
            nome = n;
            ouro = o;
            prata = p;
            bronze = b;
        }
        public int CompareTo(object obj)
        {
            Pais x = obj as Pais;
            if (this.ouro > x.ouro) return -1;
            if (this.ouro < x.ouro) return 1;
            if (this.prata > x.prata) return -1;
            if (this.prata < x.prata) return 1;
            if (this.bronze > x.bronze) return -1;
            if (this.bronze < x.bronze) return 1;
            return this.nome.CompareTo(x.nome);
        }
        public override string ToString()
        {
            return $"{nome} {ouro} {prata} {bronze}";
        }
    }
    class Teste
    {
        public static void Ordenar(IComparable[] p)
        {
            for (int i = 0; i <= p.Length - 2; i++)
                for (int j = i + 1; j <= p.Length - 1; j++)
                    if (p[i].CompareTo(p[j]) == 1)
                    {
                        IComparable aux = p[i];
                        p[i] = p[j];
                        p[j] = aux;
                    }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pais p1 = new Pais("Brasil", 10, 5, 3);
            Pais p2 = new Pais("Argentina", 10, 5, 3);
            Pais p3 = new Pais("Japão", 18, 9, 4);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Pais[] x = new Pais[3];
            x[0] = p1;
            x[1] = p2;
            x[2] = p3;
            //Array.Sort(x);
            Teste.Ordenar(x);
            Console.WriteLine(x[0]);
            Console.WriteLine(x[1]);
            Console.WriteLine(x[2]);
            Console.ReadKey();
        }
    }
}
