using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Conjunto
{
    public class Conjuntos<Tipo>
    {
        private List<Tipo> elementos= new List<Tipo>();

        public Conjuntos(List<Tipo> elementos)
        {
            this.elementos = elementos;
        }

        public Conjuntos() { }

        public void Adicionar(Tipo A)
        {
            elementos.Add(A);
        }

        public bool Pertinencia(Tipo A)
        {
            bool OK = false;
            for (int i = 0; i < elementos.Count; i++)
            {
                if (elementos[i].Equals(A))
                {
                    OK = true;
                }
            }
            return OK;
        }

        public bool Continencia(Conjuntos<Tipo> A) 
        {
            bool OK = false;
            if (A.elementos.Count > elementos.Count) 
            {
                return OK;
            }
            else
            {
                for (int i = 0; i < A.elementos.Count; i++)
                {
                    for (int j = 0; j < elementos.Count; j++)
                    {
                        if (elementos[j].Equals(A.elementos[i]))
                        {
                            j = elementos.Count;
                            OK = true;
                        }
                        else 
                        {
                            OK = false;
                        }                       
                    }
                   
                }
            }
            return OK;
        }

        public String  Uniao(Conjuntos<Tipo> A)
        {
            for (int i = 0; i < A.elementos.Count; i++)
            {
                for (int j = 0; j < elementos.Count; j++)
                {
                    if (!A.Pertinencia(elementos[j]))
                    {
                        A.Adicionar(elementos[j]);
                    }                  
                }
            }
            
            String uni = "{ ";
                for (int i = 0; i < A.elementos.Count; i++)
                {
                    if (uni == "")
                        uni = ""+ A.elementos[i]; 
                    else
                        uni = uni + ", " + A.elementos[i];
                }
                uni = uni + " }";
          
            return uni;
       }

        public String Interseccao(Conjuntos<Tipo> A)
        {
            Conjuntos<Tipo> Inter = new Conjuntos<Tipo>();
            for (int i = 0; i < A.elementos.Count; i++)
            {
                for (int j = 0; j < elementos.Count; j++)
                {
                    if (A.Pertinencia(elementos[j]))
                    {
                        Inter.Adicionar(elementos[j]);
                       elementos.RemoveAt(j);
                    }
                }
            }

            String uni = "{ ";            
            for (int i = 0; i < Inter.elementos.Count; i++)
            {
                if (uni == "")
                    uni += Inter.elementos[i];
                else
                    uni = uni + ", " + Inter.elementos[i];
            }
            uni = uni + " }";

            return uni;
        }

        public String Diferenca(Conjuntos<Tipo> A)
        {
            Conjuntos<Tipo> difere = new Conjuntos<Tipo>();
            Conjuntos<Tipo> teste = A;

            int k = 0;
            for (int i = 0; i < teste.elementos.Count; i++)
            {
                
                for (int j=k; j < elementos.Count; j++)
                {
                    if (teste.Pertinencia(elementos[j]))
                    {
                        //A.elementos.RemoveAt(i);
                        elementos.RemoveAt(j);
                        j = elementos.Count;
                        k++;

                    }
                    else
                    {
                        difere.Adicionar(teste.elementos[i]);
                    }
                }
            }

            String dif = "{ ";
            for (int i = 0; i < difere.elementos.Count; i++)
            {
                if (dif == "")
                    dif += difere.elementos[i];
                else
                    dif = dif + ", " + difere.elementos[i];
            }
            dif = dif + " }";

            return dif;
        }

        public ArrayList Produto(Conjuntos<Tipo> A)
        {
            //Conjuntos<Tipo> prod = new Conjuntos<Tipo>();
            ArrayList produto = new ArrayList();
            String prods="";
            for (int i = 0; i < A.elementos.Count; i++)
            {
                for (int j = 0; j < elementos.Count; j++)
                {
                    produto.Add("<" + A.elementos[i] + "," + elementos[j] + ">, ");
                     
                }
                  
            }
            return produto;
        }

        public void limparConjuntos() { elementos.Clear(); }

        public int Quantidade(List<Tipo> elementos)
        {
            return elementos.Count();
        }

        
    }




    
}
