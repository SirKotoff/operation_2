using System;
using System.Collections.Generic;

namespace T2
{
    class Polynom
    {
        List<int> polynom = new List<int>();     //Список элементов (членов)
        int PowPolynom = 0;                      //Степень многочлена
                                                 //Степень многочлена кол-во элем
      
        public int GetPol
        {
            get { return PowPolynom; }
        }
        
        public List<int> GetItems()
        {
            return polynom;
        }



        //индексатор для получения любого элемента списка
        public int this[int i]
        {
            get
            {
                if (i > polynom.Count - 1) return 0;
                return polynom[i];
            }
            set
            {
                if (i > polynom.Count - 1) polynom[i] = value;
            }
        }
   


        public Polynom(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                polynom.Add(items[i]);
                PowPolynom = items.Length;
            }   
        }

        public Polynom(List<int> items)
        {
            polynom = items;
            PowPolynom = items.Count;
        }



       //Перегрузки операторов (большим является многочлен с большей степенью)
        public static bool operator >(Polynom x, Polynom y)
        {
            if (x.GetPol > y.GetPol)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }

        public static bool operator <(Polynom x, Polynom y)
        {
            return !(x > y);
        }

        public static Polynom operator +(Polynom x, Polynom y)
        {
            if (x < y)
            {
                Polynom tmp = new Polynom(x.GetItems());
                x = y;
                y = tmp;
            }
            List<int> ResItems = new List<int>();
            int offset = x.GetPol - y.GetPol;
            for (int i = 0; i < x.GetPol; i++)
            {
                if (i >= offset)
                {
                    ResItems.Add(x[i] + y[i - offset]);
                }
                else
                {
                    ResItems.Add(x[i]);
                } 
            }

            Polynom Res = new Polynom(ResItems);
            return Res;
        }
      


        public override string ToString()
        {
            string res = string.Empty;
            for (int i = 0; i < polynom.Count; i++)
            {
                res += polynom[i] +((polynom.Count - (i + 1) != 0) ? "x^" + (polynom.Count - (i + 1)).ToString() : "") + (i != (polynom.Count - 1) ? "+" : "");
            }

            return res;
        }
    }
}
