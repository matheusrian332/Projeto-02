﻿namespace Projeto_02
{
    partial class UserControlGerenciarCurso
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerenciarCurso = new System.Windows.Forms.Button();
            this.btnRegistrarCurso = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gerenciamento de Cursos";
            // 
            // btnGerenciarCurso
            // 
            this.btnGerenciarCurso.FlatAppearance.BorderSize = 2;
            this.btnGerenciarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciarCurso.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarCurso.Location = new System.Drawing.Point(412, 156);
            this.btnGerenciarCurso.Name = "btnGerenciarCurso";
            this.btnGerenciarCurso.Size = new System.Drawing.Size(127, 54);
            this.btnGerenciarCurso.TabIndex = 1;
            this.btnGerenciarCurso.Text = "Gerenciar Curso Existente";
            this.btnGerenciarCurso.UseVisualStyleBackColor = true;
            this.btnGerenciarCurso.Click += new System.EventHandler(this.btnGerenciarCurso_Click);
            // 
            // btnRegistrarCurso
            // 
            this.btnRegistrarCurso.FlatAppearance.BorderSize = 2;
            this.btnRegistrarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCurso.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCurso.Location = new System.Drawing.Point(204, 156);
            this.btnRegistrarCurso.Name = "btnRegistrarCurso";
            this.btnRegistrarCurso.Size = new System.Drawing.Size(127, 54);
            this.btnRegistrarCurso.TabIndex = 0;
            this.btnRegistrarCurso.Text = "Registrar Curso";
            this.btnRegistrarCurso.UseVisualStyleBackColor = true;
            this.btnRegistrarCurso.Click += new System.EventHandler(this.btnRegistrarCurso_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(658, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 30);
            this.label8.TabIndex = 6;
            this.label8.Text = "EF";
            // 
            // UserControlGerenciarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGerenciarCurso);
            this.Controls.Add(this.btnRegistrarCurso);
            this.Controls.Add(this.label1);
            this.Name = "UserControlGerenciarCurso";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerenciarCurso;
        private System.Windows.Forms.Button btnRegistrarCurso;
        private System.Windows.Forms.Label label8;
    }
}
