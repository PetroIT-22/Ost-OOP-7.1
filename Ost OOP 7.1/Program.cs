using System;
using System.Collections;

namespace Ost_OOP_7._1
{
    public class PoultryFarm : IComparable
    {
        public string name;
        public double S;
        public float naselena;
        public int age;
        public string president;



        public PoultryFarm(string name, double S, float naselena, int age, string president)
        {
            this.name = name;
            this.S = S;
            this.naselena = naselena;
            this.age = age;
            this.president = president;
        }

        public class SortByCena : IComparer
        {
            int IComparer.Compare(object ob1, object ob2)
            {
                PoultryFarm p1 = (PoultryFarm)ob1;
                PoultryFarm p2 = (PoultryFarm)ob2;
                if (p1.naselena > p2.naselena) return 1;
                if (p1.naselena < p2.naselena) return -1;
                return 0;
            }
        }

        public int CompareTo(object pers)
        {
            PoultryFarm p = (PoultryFarm)pers;
            if (this.S > p.S) return 1;
            if (this.S < p.S) return -1; return 0;
        }
        public void Info()
        {

            Console.WriteLine("{0, -15}{1, -10}{2, -15}{3, -15}{4, -10}", name, S, naselena, age, president);
        }
    }

    class Chiken : IEnumerable
    {
        public string name;
        public double weight;
        public float cena;
        public int number;
        public float height;



        public Chiken(string name, double weight, float cena, int number, float height)
        {
            this.name = name;
            this.weight = weight;
            this.cena = cena;
            this.number = number;
            this.height = height;
        }

        protected int size;
        protected PoultryFarm[] container;

        public Chiken()
        {
            size = 10;
            container = new PoultryFarm[size];
            FillContainer();
        }

        public Chiken(int size)
        {
            this.size = size;
            container = new PoultryFarm[size];
            FillContainer();
        }
        public Chiken(PoultryFarm[] container)
        {
            this.container = container;
            size = container.Length;
        }
        void FillContainer()
        {


            PoultryFarm p1 = new PoultryFarm("Cermany", 500, 75, 20, "Merkel");
            PoultryFarm p2 = new PoultryFarm("France", 480, 68, 20, "Makron");
            PoultryFarm p3 = new PoultryFarm("Italy", 550, 64, 13, "Musoliny");
            PoultryFarm p4 = new PoultryFarm("Neatherlands", 80, 38, 100, "Roben");
            PoultryFarm p5 = new PoultryFarm("Spain", 490, 59, 50, "Barsa");
            PoultryFarm p6 = new PoultryFarm("Portugal", 120, 41, 20, "Ronaldo");
            PoultryFarm p7 = new PoultryFarm("Canada", 2000, 42, 10, "Liza II");
            PoultryFarm p8 = new PoultryFarm("USA", 1800, 900, 18, "Obama");
            PoultryFarm p9 = new PoultryFarm("Brazil",1659 , 600, 6, "Zora");
            PoultryFarm p10 = new PoultryFarm("Ukraine", 765, 37, 23, "Green");
            PoultryFarm[] pn = new PoultryFarm[10];
            pn[0] = p1;
            pn[1] = p2;
            pn[2] = p3;
            pn[3] = p4;
            pn[4] = p5;
            pn[5] = p6;
            pn[6] = p7;
            pn[7] = p8;
            pn[8] = p9;
            pn[9] = p10;



        }
        public IEnumerator GetEnumerator()
        {
            Array.Sort(container);
            return container.GetEnumerator();
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

            PoultryFarm p1 = new PoultryFarm("Cermany", 500, 75, 20, "Merkel");
            PoultryFarm p2 = new PoultryFarm("France", 480, 68, 20, "Makron");
            PoultryFarm p3 = new PoultryFarm("Italy", 550, 64, 13, "Musoliny");
            PoultryFarm p4 = new PoultryFarm("Neatherlands", 80, 38, 100, "Roben");
            PoultryFarm p5 = new PoultryFarm("Spain", 490, 59, 50, "Barsa");
            PoultryFarm p6 = new PoultryFarm("Portugal", 120, 41, 20, "Ronaldo");
            PoultryFarm p7 = new PoultryFarm("Canada", 2000, 42, 10, "Liza II");
            PoultryFarm p8 = new PoultryFarm("USA", 1800, 900, 18, "Obama");
            PoultryFarm p9 = new PoultryFarm("Brazil", 1659, 600, 6, "Zora");
            PoultryFarm p10 = new PoultryFarm("Ukraine", 765, 37, 23, "Green");
            PoultryFarm[] pn = new PoultryFarm[10];
            pn[0] = p1;
            pn[1] = p2;
            pn[2] = p3;
            pn[3] = p4;
            pn[4] = p5;
            pn[5] = p6;
            pn[6] = p7;
            pn[7] = p8;
            pn[8] = p9;
            pn[9] = p10;
            Array.Sort(pn);

            Console.WriteLine("\t\t\tПорівняння за площою\n{0, -15}{1, -10}{2, -15}{3, -15}{4, -10}", "Країна", "Площа", "Населення", "Вік", "Президент");
            foreach (PoultryFarm elem in pn) elem.Info();
            Console.WriteLine("\n\t\t\tСортування за населенням");
            Array.Sort(pn, new PoultryFarm.SortByCena());
            foreach (PoultryFarm elem in pn) elem.Info();

            int size = 10;
            Chiken chic = new Chiken(size);

            Console.WriteLine("\t\t\tСортування за населенням");
            foreach (Chiken chics in chic)
            {
                Console.WriteLine("{0, -15}{1, -10}{2, -15}{3, -15}{4, -10}", chic.name, chic.weight, chic.cena, chic.number, chic.height);
            }





        }
    }
}
