namespace Trabaio
{
    partial class Formulario
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
            this.nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.endereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.filhos = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.sangue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.civil = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ver = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(12, 94);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(191, 20);
            this.nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Idade";
            // 
            // idade
            // 
            this.idade.Location = new System.Drawing.Point(12, 139);
            this.idade.Name = "idade";
            this.idade.Size = new System.Drawing.Size(95, 20);
            this.idade.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo";
            // 
            // sexo
            // 
            this.sexo.Location = new System.Drawing.Point(113, 139);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(90, 20);
            this.sexo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cargo";
            // 
            // cargo
            // 
            this.cargo.Location = new System.Drawing.Point(12, 183);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(95, 20);
            this.cargo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Salário";
            // 
            // salario
            // 
            this.salario.Location = new System.Drawing.Point(113, 183);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(90, 20);
            this.salario.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "Remover Funcionario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.removerFuncionario);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 20);
            this.button2.TabIndex = 12;
            this.button2.Text = "Adicionar Funcionario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addFuncionario);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "E-Mail";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(12, 227);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(95, 20);
            this.email.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Endereço";
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(12, 270);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(191, 20);
            this.endereco.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nº Filhos";
            // 
            // filhos
            // 
            this.filhos.Location = new System.Drawing.Point(113, 227);
            this.filhos.Name = "filhos";
            this.filhos.Size = new System.Drawing.Size(90, 20);
            this.filhos.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Telefone";
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(12, 313);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(95, 20);
            this.telefone.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tipo Sanguíneo";
            // 
            // sangue
            // 
            this.sangue.Location = new System.Drawing.Point(113, 313);
            this.sangue.Name = "sangue";
            this.sangue.Size = new System.Drawing.Size(90, 20);
            this.sangue.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Estado Civil";
            // 
            // civil
            // 
            this.civil.Location = new System.Drawing.Point(12, 355);
            this.civil.Name = "civil";
            this.civil.Size = new System.Drawing.Size(95, 20);
            this.civil.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gogoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(216, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gogoToolStripMenuItem
            // 
            this.gogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem});
            this.gogoToolStripMenuItem.Name = "gogoToolStripMenuItem";
            this.gogoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.gogoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.SalvarTXT);
            // 
            // ver
            // 
            this.ver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ver.Location = new System.Drawing.Point(12, 28);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(191, 20);
            this.ver.TabIndex = 31;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 20);
            this.button3.TabIndex = 30;
            this.button3.Text = "Ver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.verClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 20);
            this.button4.TabIndex = 32;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.limpar);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 416);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.civil);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sangue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.filhos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Formulario";
            this.Text = "Formulário";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox salario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox filhos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox sangue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox civil;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gogoToolStripMenuItem;
        private System.Windows.Forms.TextBox ver;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.Button button4;
    }
}

