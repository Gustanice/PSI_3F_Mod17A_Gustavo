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
    public partial class Alunos : Form
    {
        public Alunos()
        {
            InitializeComponent();
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Alunos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.database1DataSet.Alunos);

        }
    }
}
