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
    public partial class CursosForm : Form
    {
        public CursosForm()
        {
            InitializeComponent();
        }

        private void cursosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cursosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void CursosForm_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'database1DataSet.Cursos'. Você pode movê-la ou removê-la conforme necessário.
            this.cursosTableAdapter.Fill(this.database1DataSet.Cursos);

        }
    }
}
