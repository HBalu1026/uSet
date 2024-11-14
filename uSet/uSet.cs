using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uSet
{
    internal class uSet
    {
        double[] Sor;
        int hossz;
        uSet() { Sor = new double[100]; }
        uSet(int hossz) { Sor = new double[hossz]; }

        public double[] Sor1 { get => Sor; set => Sor = value; }
        public int Hossz { get => hossz; set => hossz = value; }

        public void Put(double elem)
        {
            bool benneVan = false;
            for (int i = 0; i < Sor.Length; i++)
            {
                if (Sor[i] == elem)
                {
                    throw new Exception();
                }
                Sor.Append(elem);
            }
        }
        public bool Contain(double elem)
        {
            for (int i = 0; i < Sor.Length; i++)
            {
                if (Sor[i] == elem)
                {
                    return true;
                }
            }
            return false;
        }
        public void Remove(double elem) 
        {
            double[] uReplace = new double[Sor.Length-1];

            for(int i = 0;i < Sor.Length;i++)
            {
                if(Sor[i] != elem)
                {
                    uReplace.Append(Sor[i]);
                }
            }
            Sor = uReplace;
        }
        public void Clear()
        {
            Sor = new double[0];
        }
        public int Count()
        {
            return Sor.Length;
        }
        public int GetSize()
        {
            return Hossz;
        }
    }
}
