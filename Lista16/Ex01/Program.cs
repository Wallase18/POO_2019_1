using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    interface IMedia
    {
        int GetMedia();
    }
    class DisciplinaSemestral : IMedia
    {
        private int nota1, nota2, notaF;
        public DisciplinaSemestral(int n1, int n2, int nf)
        {
            nota1 = n1;
            nota2 = n2;
            notaF = nf;
        }
        public int GetMedia()
        {
            int m = (2 * nota1 + 3 * nota2) / 5;
            if (m < 60) m = (m + notaF) / 2;
            return m;
        }
    }
    class DisciplinaAnual : IMedia
    {
        private int nota1, nota2, nota3, nota4, notaF;
        public DisciplinaAnual(int n1, int n2, int n3, int n4, int nf)
        {
            nota1 = n1;
            nota2 = n2;
            nota3 = n3;
            nota4 = n4;
            notaF = nf;
        }
        public int GetMedia()
        {
            int m = (2 * nota1 + 2 * nota2 + 3 * nota3 + 3 * nota4) / 10;
            if (m < 60) m = (m + notaF) / 2;
            return m;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IMedia[] v = new IMedia[4];
            v[0] = new DisciplinaSemestral(100, 50, 0);
            v[1] = new DisciplinaSemestral(80, 60, 0);
            v[2] = new DisciplinaAnual(100, 75, 40, 0, 30);
            v[3] = new DisciplinaAnual(100, 50, 50, 60, 0);
            for (int i = 0; i < 4; i++)
                Console.WriteLine(v[i].GetMedia());
            Console.ReadKey();
        }
    }
}
