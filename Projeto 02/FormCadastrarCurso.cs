﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_02
{
    public partial class FormCadastrarCurso : Form
    {
        ClassCurso curso = new ClassCurso();

        public FormCadastrarCurso()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            curso.Nome = txtNome.Text;
            curso.CargaHoraria = int.Parse(txtCargaHoraria.Text);
            curso.CadastrarCurso();
        }
    }
}
