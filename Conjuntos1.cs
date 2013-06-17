using System;
using System.Linq;
using System.Text;
using System.Collections;


namespace Conjunto
{

    public class Conjuntos1
    {
        public ArrayList Subconjuntos(ArrayList Conjunto)
        {
            ArrayList resultado = new ArrayList();
            ArrayList aux = new ArrayList();

            foreach (System.String item in Conjunto)
            {
                aux.Add(item);
                resultado.Add(item);
            }            
            double total = Math.Pow(2,Conjunto.Count);
          
            for (int i= 0; i<total ; i++) 
            { 
                for (int j=i; j<Conjunto.Count ; j++)
                {
                    if (j > i)
                    {
                        resultado.Add(resultado[i].ToString() + resultado[j].ToString());
                    }
                    else 
                    {
                        resultado.Add(Conjunto[i].ToString() + Conjunto[i].ToString());
                    }
                }
            }
            return resultado;

        }
    }
}
