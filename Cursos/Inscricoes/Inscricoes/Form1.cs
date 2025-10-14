using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inscricoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void inscricaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inscricaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Inscricao'. Você pode movê-la ou removê-la conforme necessário.
            this.inscricaoTableAdapter.Fill(this.database1DataSet.Inscricao);

        }
    }
}
