namespace Escola
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadFuncionario = new System.Windows.Forms.Button();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadFuncionario
            // 
            this.btnCadFuncionario.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadFuncionario.Location = new System.Drawing.Point(416, 367);
            this.btnCadFuncionario.Name = "btnCadFuncionario";
            this.btnCadFuncionario.Size = new System.Drawing.Size(237, 40);
            this.btnCadFuncionario.TabIndex = 0;
            this.btnCadFuncionario.Text = "Cadastrar Funcionário";
            this.btnCadFuncionario.UseVisualStyleBackColor = true;
            this.btnCadFuncionario.Click += new System.EventHandler(this.btnCadFuncionario_Click);
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadAluno.Location = new System.Drawing.Point(140, 367);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(237, 40);
            this.btnCadAluno.TabIndex = 1;
            this.btnCadAluno.Text = "Cadastrar Aluno";
            this.btnCadAluno.UseVisualStyleBackColor = true;
            this.btnCadAluno.Click += new System.EventHandler(this.btnCadAluno_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadAluno);
            this.Controls.Add(this.btnCadFuncionario);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCadFuncionario;
        private Button btnCadAluno;
    }
}