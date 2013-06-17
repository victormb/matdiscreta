using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conjunto
{
    public partial class FormOperacoesConjuntos : Form
    {

        public Conjuntos<string> N = new Conjuntos<string>();
        public Conjuntos<string> A = new Conjuntos<string>();
        ArrayList listaTeste = new ArrayList();
        ArrayList lista = new ArrayList();
        Conjuntos1 aux = new Conjuntos1();
        int i = 0;
        String texto;
        
        public FormOperacoesConjuntos()
        {
            InitializeComponent();
        }

        private void FormOperacoesConjuntos_Load(object sender, EventArgs e)
        {
           
        }

        private void textBoxElemento_TextChanged(object sender, EventArgs e)
        {
                       
          
        }
             

        private void buttonPertence_Click(object sender, EventArgs e)
        {  
            if (N.Pertinencia(textBoxElemento.Text))
            {
                MessageBox.Show("Pertence!");
            }
            else { MessageBox.Show("Não Pertence!"); }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            N.Adicionar(textBoxAdd.Text);
            try
            {
                lista.Add(int.Parse(textBoxAdd.Text));
                listaTeste.Add(textBoxAdd.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("skdjf","sadfsd"+ex);
            }
            i++;
            textBoxAdd.Clear();
            textBoxAdd.Focus();
        }

        private void textBoxAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddConjA_Click(object sender, EventArgs e)
        {
            A.Adicionar(textBoxConjA.Text);        
            textBoxConjA.Clear();
            textBoxConjA.Focus();
        }

        private void textBoxConjA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonContem_Click(object sender, EventArgs e)
        {
            if (N.Continencia(A))
            {
                MessageBox.Show("Contém!");
            }
            else { MessageBox.Show("Não Contém!"); }
        }

        private void button1_Click(object sender, EventArgs e)        
        {
            String uniao;
            uniao = A.Uniao(N);
            MessageBox.Show(uniao, "Uniao");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String Intersec;
            Intersec = A.Interseccao(N);
            MessageBox.Show(Intersec, "Intersecção");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Difer;
            Difer = A.Diferenca(N);
            MessageBox.Show(Difer, "Diferença");
           
        }

        private void buttonProd_Click(object sender, EventArgs e)
        {
            ArrayList Prod;
            Prod =  A.Produto(N);
            //MessageBox.Show(Prod, "Produto");
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            A.limparConjuntos();
            N.limparConjuntos();

            MessageBox.Show("Conjuntos foram limpados!", "Limpados");
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {            
            HeapSort.Heapsort(lista);
           
            foreach (System.Int32 item in lista)
            {
                texto = texto+"\n " + Convert.ToString(item.ToString());
            }
            MessageBox.Show(texto, "HeapSort - Que Lindo!");
            texto = " ";
        }

        private void buttonEndorrelacao_Click(object sender, EventArgs e)
        {
            ArrayList Prod;
            Prod = N.Produto(N);
            texto += "{";
            foreach (System.String x in Prod)
            {
                texto = texto + x.ToString();
            }
            texto += "}";
            MessageBox.Show(texto, "Endorrelação de N");

            ///////////////////////////////////////////////
            ArrayList Resultado;
            int i = 1;
            Resultado = aux.Subconjuntos(Prod);
            texto += "\n1- {";
            foreach (System.String x in Resultado)
            {
                i++;
                texto = texto + x.ToString();
                texto += "}";
                texto += Convert.ToString(i) + "- {";

            }
            texto += "}";
            MessageBox.Show(texto, "Subconjuntos de N");
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArrayList Resultado;
            int i = 1;
            Resultado = aux.Subconjuntos(listaTeste);
            texto += "1- {";
            foreach (System.String x in Resultado)
            {
                i++;
                texto = texto + x.ToString();
                texto += "}\n";
                texto += Convert.ToString(i)  +"- {";
                
            }
            texto += "}";
            MessageBox.Show(texto, "Subconjuntos de N");
        }
       
    }
}
