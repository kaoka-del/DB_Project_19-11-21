namespace PROJETOBDDEDE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.schoolManagerDataSet = new PROJETOBDDEDE.SchoolManagerDataSet();
            this.schoolManagerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolManagerDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.btnCadProf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gp_Cadastro = new System.Windows.Forms.GroupBox();
            this.gp_EXC = new System.Windows.Forms.GroupBox();
            this.btn_exc_Aluno = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exc_Prof = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gp_Visu = new System.Windows.Forms.GroupBox();
            this.btnVIsuAluno = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVIsuProf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gp_Mod = new System.Windows.Forms.GroupBox();
            this.btn_mod_Aluno = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_mod_Prof = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagerDataSetBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gp_Cadastro.SuspendLayout();
            this.gp_EXC.SuspendLayout();
            this.gp_Visu.SuspendLayout();
            this.gp_Mod.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoolManagerDataSet
            // 
            this.schoolManagerDataSet.DataSetName = "SchoolManagerDataSet";
            this.schoolManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolManagerDataSetBindingSource
            // 
            this.schoolManagerDataSetBindingSource.DataSource = this.schoolManagerDataSet;
            this.schoolManagerDataSetBindingSource.Position = 0;
            // 
            // schoolManagerDataSetBindingSource1
            // 
            this.schoolManagerDataSetBindingSource1.DataSource = this.schoolManagerDataSet;
            this.schoolManagerDataSetBindingSource1.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnPesquisa);
            this.groupBox1.Controls.Add(this.btnExcluir);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnCadastro);
            this.groupBox1.Location = new System.Drawing.Point(-67, -21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(1720, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPesquisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisa.BackgroundImage")));
            this.btnPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisa.Location = new System.Drawing.Point(804, 61);
            this.btnPesquisa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(99, 60);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExcluir.Location = new System.Drawing.Point(352, 62);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 55);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(238, 66);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(82, 55);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(383, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(428, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diário de um Banana";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(98, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastro.BackgroundImage")));
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastro.Location = new System.Drawing.Point(913, 62);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(82, 54);
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(125)))));
            this.btnCadAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadAluno.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnCadAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadAluno.Location = new System.Drawing.Point(21, 98);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(75, 23);
            this.btnCadAluno.TabIndex = 3;
            this.btnCadAluno.Text = "Aluno";
            this.btnCadAluno.UseVisualStyleBackColor = false;
            this.btnCadAluno.Click += new System.EventHandler(this.btnCadAluno_Click);
            // 
            // btnCadProf
            // 
            this.btnCadProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(125)))));
            this.btnCadProf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadProf.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnCadProf.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCadProf.Location = new System.Drawing.Point(175, 98);
            this.btnCadProf.Name = "btnCadProf";
            this.btnCadProf.Size = new System.Drawing.Size(83, 23);
            this.btnCadProf.TabIndex = 4;
            this.btnCadProf.Text = "Professor";
            this.btnCadProf.UseVisualStyleBackColor = false;
            this.btnCadProf.Click += new System.EventHandler(this.btnCadProf_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.CausesValidation = false;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Deseja cadastrar um:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "ou";
            // 
            // gp_Cadastro
            // 
            this.gp_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.gp_Cadastro.Controls.Add(this.btnCadAluno);
            this.gp_Cadastro.Controls.Add(this.gp_EXC);
            this.gp_Cadastro.Controls.Add(this.label2);
            this.gp_Cadastro.Controls.Add(this.btnCadProf);
            this.gp_Cadastro.Controls.Add(this.label1);
            this.gp_Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gp_Cadastro.Location = new System.Drawing.Point(300, 146);
            this.gp_Cadastro.Name = "gp_Cadastro";
            this.gp_Cadastro.Size = new System.Drawing.Size(282, 164);
            this.gp_Cadastro.TabIndex = 7;
            this.gp_Cadastro.TabStop = false;
            this.gp_Cadastro.Visible = false;
            // 
            // gp_EXC
            // 
            this.gp_EXC.BackColor = System.Drawing.Color.Transparent;
            this.gp_EXC.Controls.Add(this.btn_exc_Aluno);
            this.gp_EXC.Controls.Add(this.label6);
            this.gp_EXC.Controls.Add(this.btn_exc_Prof);
            this.gp_EXC.Controls.Add(this.label7);
            this.gp_EXC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gp_EXC.Location = new System.Drawing.Point(6, 0);
            this.gp_EXC.Name = "gp_EXC";
            this.gp_EXC.Size = new System.Drawing.Size(282, 164);
            this.gp_EXC.TabIndex = 9;
            this.gp_EXC.TabStop = false;
            this.gp_EXC.Visible = false;
            // 
            // btn_exc_Aluno
            // 
            this.btn_exc_Aluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(125)))));
            this.btn_exc_Aluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exc_Aluno.Font = new System.Drawing.Font("Verdana", 10F);
            this.btn_exc_Aluno.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_exc_Aluno.Location = new System.Drawing.Point(21, 98);
            this.btn_exc_Aluno.Name = "btn_exc_Aluno";
            this.btn_exc_Aluno.Size = new System.Drawing.Size(75, 23);
            this.btn_exc_Aluno.TabIndex = 3;
            this.btn_exc_Aluno.Text = "Aluno";
            this.btn_exc_Aluno.UseVisualStyleBackColor = false;
            this.btn_exc_Aluno.Click += new System.EventHandler(this.btn_exc_Aluno_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "ou";
            // 
            // btn_exc_Prof
            // 
            this.btn_exc_Prof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(125)))));
            this.btn_exc_Prof.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exc_Prof.Font = new System.Drawing.Font("Verdana", 10F);
            this.btn_exc_Prof.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_exc_Prof.Location = new System.Drawing.Point(187, 98);
            this.btn_exc_Prof.Name = "btn_exc_Prof";
            this.btn_exc_Prof.Size = new System.Drawing.Size(83, 23);
            this.btn_exc_Prof.TabIndex = 4;
            this.btn_exc_Prof.Text = "Professor";
            this.btn_exc_Prof.UseVisualStyleBackColor = false;
            this.btn_exc_Prof.Click += new System.EventHandler(this.btn_exc_Prof_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.CausesValidation = false;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Deseja excluir um:";
            // 
            // gp_Visu
            // 
            this.gp_Visu.BackColor = System.Drawing.Color.Transparent;
            this.gp_Visu.Controls.Add(this.btnVIsuAluno);
            this.gp_Visu.Controls.Add(this.label4);
            this.gp_Visu.Controls.Add(this.btnVIsuProf);
            this.gp_Visu.Controls.Add(this.label5);
            this.gp_Visu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gp_Visu.Location = new System.Drawing.Point(621, 146);
            this.gp_Visu.Name = "gp_Visu";
            this.gp_Visu.Size = new System.Drawing.Size(282, 164);
            this.gp_Visu.TabIndex = 8;
            this.gp_Visu.TabStop = false;
            this.gp_Visu.Visible = false;
            // 
            // btnVIsuAluno
            // 
            this.btnVIsuAluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(125)))));
            this.btnVIsuAluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVIsuAluno.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnVIsuAluno.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVIsuAluno.Location = new System.Drawing.Point(21, 98);
            this.btnVIsuAluno.Name = "btnVIsuAluno";
            this.btnVIsuAluno.Size = new System.Drawing.Size(75, 23);
            this.btnVIsuAluno.TabIndex = 3;
            this.btnVIsuAluno.Text = "Aluno";
            this.btnVIsuAluno.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.CausesValidation = false;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "ou";
            // 
            // btnVIsuProf
            // 
            this.btnVIsuProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(125)))));
            this.btnVIsuProf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVIsuProf.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnVIsuProf.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVIsuProf.Location = new System.Drawing.Point(187, 98);
            this.btnVIsuProf.Name = "btnVIsuProf";
            this.btnVIsuProf.Size = new System.Drawing.Size(83, 23);
            this.btnVIsuProf.TabIndex = 4;
            this.btnVIsuProf.Text = "Professor";
            this.btnVIsuProf.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.CausesValidation = false;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Deseja visualizar um:";
            // 
            // gp_Mod
            // 
            this.gp_Mod.BackColor = System.Drawing.Color.Transparent;
            this.gp_Mod.Controls.Add(this.btn_mod_Aluno);
            this.gp_Mod.Controls.Add(this.label8);
            this.gp_Mod.Controls.Add(this.btn_mod_Prof);
            this.gp_Mod.Controls.Add(this.label9);
            this.gp_Mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gp_Mod.Location = new System.Drawing.Point(0, 146);
            this.gp_Mod.Name = "gp_Mod";
            this.gp_Mod.Size = new System.Drawing.Size(282, 164);
            this.gp_Mod.TabIndex = 9;
            this.gp_Mod.TabStop = false;
            this.gp_Mod.Visible = false;
            // 
            // btn_mod_Aluno
            // 
            this.btn_mod_Aluno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(125)))));
            this.btn_mod_Aluno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mod_Aluno.Font = new System.Drawing.Font("Verdana", 10F);
            this.btn_mod_Aluno.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mod_Aluno.Location = new System.Drawing.Point(21, 98);
            this.btn_mod_Aluno.Name = "btn_mod_Aluno";
            this.btn_mod_Aluno.Size = new System.Drawing.Size(75, 23);
            this.btn_mod_Aluno.TabIndex = 3;
            this.btn_mod_Aluno.Text = "Aluno";
            this.btn_mod_Aluno.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.CausesValidation = false;
            this.label8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(122, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "ou";
            // 
            // btn_mod_Prof
            // 
            this.btn_mod_Prof.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(94)))), ((int)(((byte)(125)))));
            this.btn_mod_Prof.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_mod_Prof.Font = new System.Drawing.Font("Verdana", 10F);
            this.btn_mod_Prof.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mod_Prof.Location = new System.Drawing.Point(187, 98);
            this.btn_mod_Prof.Name = "btn_mod_Prof";
            this.btn_mod_Prof.Size = new System.Drawing.Size(83, 23);
            this.btn_mod_Prof.TabIndex = 4;
            this.btn_mod_Prof.Text = "Professor";
            this.btn_mod_Prof.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.CausesValidation = false;
            this.label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "Deseja modificar um:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 468);
            this.Controls.Add(this.gp_Mod);
            this.Controls.Add(this.gp_Visu);
            this.Controls.Add(this.gp_Cadastro);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolManagerDataSetBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gp_Cadastro.ResumeLayout(false);
            this.gp_EXC.ResumeLayout(false);
            this.gp_Visu.ResumeLayout(false);
            this.gp_Mod.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SchoolManagerDataSet schoolManagerDataSet;
        private System.Windows.Forms.BindingSource schoolManagerDataSetBindingSource;
        private System.Windows.Forms.BindingSource schoolManagerDataSetBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button btnCadAluno;
        private System.Windows.Forms.Button btnCadProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gp_Cadastro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox gp_Visu;
        private System.Windows.Forms.Button btnVIsuAluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVIsuProf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gp_EXC;
        private System.Windows.Forms.Button btn_exc_Aluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_exc_Prof;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gp_Mod;
        private System.Windows.Forms.Button btn_mod_Aluno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_mod_Prof;
        private System.Windows.Forms.Label label9;
    }
}

