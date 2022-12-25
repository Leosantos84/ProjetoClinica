using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salvar
{
    public partial class FPacientes : Form
    {
        public FPacientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int vcodigo = int.Parse(textBox1.Text);
                string vnome = textBox2.Text;
                int vidade = int.Parse(textBox3.Text);
                Class1 classe1 = new Class1(vcodigo, vnome, vidade);
                Class2.cadastrar(classe1);
                MessageBox.Show("Cadastrado com Sucesso");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FPacientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDClinicaDataSet.PACIENTES' table. You can move, or remove it, as needed.
            this.pACIENTESTableAdapter.Fill(this.bDClinicaDataSet.PACIENTES);

        }
    }
}
