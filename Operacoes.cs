using System;
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
            String Prod;
            Prod =  A.Produto(N);
            MessageBox.Show(Prod, "Produto");
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            A.limparConjuntos();
            N.limparConjuntos();
            MessageBox.Show("Conjuntos foram limpados!", "Limpados");
        }

    }
}
