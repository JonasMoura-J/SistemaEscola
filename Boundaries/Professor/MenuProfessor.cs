﻿using System;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class MenuProfessor : Form
    {
        readonly Home _mainForm;

        public MenuProfessor(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new CadastrarProfessor(_mainForm), sender);
        }

        private void listButn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new ListarProfessores(_mainForm), sender);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenNewForm(new RemoverProfessor(_mainForm), sender);
        } 
    }
}
