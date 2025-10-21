namespace Inscricoes
{
    partial class CursosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label escolaLabel;
            System.Windows.Forms.Label nome_cursoLabel;
            System.Windows.Forms.Label vagasLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label duracao_cursoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursosForm));
            this.database1DataSet = new Inscricoes.Database1DataSet();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cursosTableAdapter = new Inscricoes.Database1DataSetTableAdapters.CursosTableAdapter();
            this.tableAdapterManager = new Inscricoes.Database1DataSetTableAdapters.TableAdapterManager();
            this.cursosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.escolaTextBox = new System.Windows.Forms.TextBox();
            this.nome_cursoTextBox = new System.Windows.Forms.TextBox();
            this.vagasTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.duracao_cursoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.cursosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            idLabel = new System.Windows.Forms.Label();
            escolaLabel = new System.Windows.Forms.Label();
            nome_cursoLabel = new System.Windows.Forms.Label();
            vagasLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            duracao_cursoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingNavigator)).BeginInit();
            this.cursosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "Cursos";
            this.cursosBindingSource.DataSource = this.database1DataSet;
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursosTableAdapter = this.cursosTableAdapter;
            this.tableAdapterManager.InscricaoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Inscricoes.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cursosBindingNavigator
            // 
            this.cursosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cursosBindingNavigator.BindingSource = this.cursosBindingSource;
            this.cursosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cursosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cursosBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cursosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cursosBindingNavigatorSaveItem});
            this.cursosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cursosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cursosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cursosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cursosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cursosBindingNavigator.Name = "cursosBindingNavigator";
            this.cursosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cursosBindingNavigator.Size = new System.Drawing.Size(950, 33);
            this.cursosBindingNavigator.TabIndex = 0;
            this.cursosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(115, 106);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(235, 103);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // escolaLabel
            // 
            escolaLabel.AutoSize = true;
            escolaLabel.Location = new System.Drawing.Point(111, 141);
            escolaLabel.Name = "escolaLabel";
            escolaLabel.Size = new System.Drawing.Size(59, 20);
            escolaLabel.TabIndex = 3;
            escolaLabel.Text = "escola:";
            // 
            // escolaTextBox
            // 
            this.escolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "escola", true));
            this.escolaTextBox.Location = new System.Drawing.Point(235, 135);
            this.escolaTextBox.Name = "escolaTextBox";
            this.escolaTextBox.Size = new System.Drawing.Size(100, 26);
            this.escolaTextBox.TabIndex = 4;
            // 
            // nome_cursoLabel
            // 
            nome_cursoLabel.AutoSize = true;
            nome_cursoLabel.Location = new System.Drawing.Point(115, 170);
            nome_cursoLabel.Name = "nome_cursoLabel";
            nome_cursoLabel.Size = new System.Drawing.Size(96, 20);
            nome_cursoLabel.TabIndex = 5;
            nome_cursoLabel.Text = "nome curso:";
            // 
            // nome_cursoTextBox
            // 
            this.nome_cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "nome_curso", true));
            this.nome_cursoTextBox.Location = new System.Drawing.Point(235, 167);
            this.nome_cursoTextBox.Name = "nome_cursoTextBox";
            this.nome_cursoTextBox.Size = new System.Drawing.Size(100, 26);
            this.nome_cursoTextBox.TabIndex = 6;
            // 
            // vagasLabel
            // 
            vagasLabel.AutoSize = true;
            vagasLabel.Location = new System.Drawing.Point(115, 202);
            vagasLabel.Name = "vagasLabel";
            vagasLabel.Size = new System.Drawing.Size(55, 20);
            vagasLabel.TabIndex = 7;
            vagasLabel.Text = "vagas:";
            // 
            // vagasTextBox
            // 
            this.vagasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "vagas", true));
            this.vagasTextBox.Location = new System.Drawing.Point(235, 199);
            this.vagasTextBox.Name = "vagasTextBox";
            this.vagasTextBox.Size = new System.Drawing.Size(100, 26);
            this.vagasTextBox.TabIndex = 8;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(115, 234);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(81, 20);
            descricaoLabel.TabIndex = 9;
            descricaoLabel.Text = "descricao:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(235, 231);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 26);
            this.descricaoTextBox.TabIndex = 10;
            // 
            // duracao_cursoLabel
            // 
            duracao_cursoLabel.AutoSize = true;
            duracao_cursoLabel.Location = new System.Drawing.Point(115, 266);
            duracao_cursoLabel.Name = "duracao_cursoLabel";
            duracao_cursoLabel.Size = new System.Drawing.Size(114, 20);
            duracao_cursoLabel.TabIndex = 11;
            duracao_cursoLabel.Text = "duracao curso:";
            // 
            // duracao_cursoTextBox
            // 
            this.duracao_cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cursosBindingSource, "duracao_curso", true));
            this.duracao_cursoTextBox.Location = new System.Drawing.Point(235, 263);
            this.duracao_cursoTextBox.Name = "duracao_cursoTextBox";
            this.duracao_cursoTextBox.Size = new System.Drawing.Size(100, 26);
            this.duracao_cursoTextBox.TabIndex = 12;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover seguinte";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // cursosBindingNavigatorSaveItem
            // 
            this.cursosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cursosBindingNavigatorSaveItem.Image")));
            this.cursosBindingNavigatorSaveItem.Name = "cursosBindingNavigatorSaveItem";
            this.cursosBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.cursosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.cursosBindingNavigatorSaveItem.Click += new System.EventHandler(this.cursosBindingNavigatorSaveItem_Click);
            // 
            // CursosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(escolaLabel);
            this.Controls.Add(this.escolaTextBox);
            this.Controls.Add(nome_cursoLabel);
            this.Controls.Add(this.nome_cursoTextBox);
            this.Controls.Add(vagasLabel);
            this.Controls.Add(this.vagasTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(duracao_cursoLabel);
            this.Controls.Add(this.duracao_cursoTextBox);
            this.Controls.Add(this.cursosBindingNavigator);
            this.Name = "CursosForm";
            this.Text = "CursosForm";
            this.Load += new System.EventHandler(this.CursosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingNavigator)).EndInit();
            this.cursosBindingNavigator.ResumeLayout(false);
            this.cursosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private Database1DataSetTableAdapters.CursosTableAdapter cursosTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cursosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cursosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox escolaTextBox;
        private System.Windows.Forms.TextBox nome_cursoTextBox;
        private System.Windows.Forms.TextBox vagasTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox duracao_cursoTextBox;
    }
}