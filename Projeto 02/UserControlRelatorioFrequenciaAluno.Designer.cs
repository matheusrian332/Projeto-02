﻿namespace Projeto_02
{
    partial class UserControlRelatorioFrequenciaAluno
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeAlunoDesejado = new System.Windows.Forms.TextBox();
            this.btnEmitirRelatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nome do(a) Aluno(a):";
            // 
            // txtNomeAlunoDesejado
            // 
            this.txtNomeAlunoDesejado.Location = new System.Drawing.Point(146, 298);
            this.txtNomeAlunoDesejado.Name = "txtNomeAlunoDesejado";
            this.txtNomeAlunoDesejado.Size = new System.Drawing.Size(291, 20);
            this.txtNomeAlunoDesejado.TabIndex = 54;
            // 
            // btnEmitirRelatorio
            // 
            this.btnEmitirRelatorio.FlatAppearance.BorderSize = 2;
            this.btnEmitirRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmitirRelatorio.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirRelatorio.Location = new System.Drawing.Point(480, 282);
            this.btnEmitirRelatorio.Name = "btnEmitirRelatorio";
            this.btnEmitirRelatorio.Size = new System.Drawing.Size(89, 51);
            this.btnEmitirRelatorio.TabIndex = 52;
            this.btnEmitirRelatorio.Text = "Emitir Relatório";
            this.btnEmitirRelatorio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 56);
            this.label1.TabIndex = 53;
            this.label1.Text = "Emissão do Relatório de Frequência\r\ndo Aluno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(662, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 30);
            this.label8.TabIndex = 51;
            this.label8.Text = "EF";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(3, 64);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(704, 212);
            this.reportViewer1.TabIndex = 56;
            // 
            // UserControlRelatorioFrequenciaAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeAlunoDesejado);
            this.Controls.Add(this.btnEmitirRelatorio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "UserControlRelatorioFrequenciaAluno";
            this.Size = new System.Drawing.Size(710, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeAlunoDesejado;
        private System.Windows.Forms.Button btnEmitirRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
