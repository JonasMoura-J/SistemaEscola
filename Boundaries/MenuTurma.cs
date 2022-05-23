﻿using System;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class MenuTurma : Form
    {
        private readonly Home _mainForm;

        public MenuTurma(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            _mainForm.OpenChildForm(new CadastrarTurma(_mainForm), sender);
        }
    }
}
