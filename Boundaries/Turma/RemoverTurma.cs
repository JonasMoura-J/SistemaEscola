﻿using SistemaEscola.Controllers;
using SistemaEscola.Entities.Formularios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaEscola
{
    public partial class RemoverTurma : Form
    {
        private readonly Home _mainForm;

        ControladorTurma controladorTurma = new ControladorTurma();

        List<FormularioTurma> turmas = new List<FormularioTurma>();

        public RemoverTurma(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void RemoverTurma_Load(object sender, EventArgs e)
        {
            controladorTurma.FindAll().ForEach(t => turmas.Add(new FormularioTurma
            {
                Id = t.Id,
                Nome = t.Nome
            }));

            turmas.ForEach(t => turmaComboBox.Items.Add(t.Nome));
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (turmaComboBox.SelectedItem != null)
            {
                var confirmScreen = new ConfirmDeletion("turma");
                confirmScreen.ShowDialog();

                if (confirmScreen.Confirmation)
                {
                    controladorTurma.Delete(turmas.Where(t => t.Nome == turmaComboBox.SelectedItem.ToString())
                        .First().Id);

                    _mainForm.OpenNewForm(new MenuTurma(_mainForm), sender, null, true);
                }
            }
        }
    }
}