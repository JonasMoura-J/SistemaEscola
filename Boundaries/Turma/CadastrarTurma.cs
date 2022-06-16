﻿using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class CadastrarTurma : Form
    {
        readonly Home _mainForm;

        readonly ControladorTurma controladorTurma = new ControladorTurma();
        readonly ControladorAluno controladorAluno = ControladorAluno.Instance;
        readonly ControladorDisciplina controladorDisciplina = new ControladorDisciplina();

        readonly List<NamePanel> alunosPanels = new List<NamePanel>();
        readonly List<int> alunosPanelLengths = new List<int>();
        readonly List<NamePanel> disciplinasPanels = new List<NamePanel>();
        readonly List<int> disciplinasPanelLengths = new List<int>();

        readonly List<TextBox> textBoxes = new List<TextBox>();

        readonly List<FormularioAluno> alunos = new List<FormularioAluno>();
        readonly List<FormularioDisciplina> disciplinas = new List<FormularioDisciplina>();

        readonly List<string> selectedAlunos = new List<string>();
        readonly List<string> selectedDisciplinas = new List<string>();

        public CadastrarTurma(Home mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void CadastrarTurma_Load(object sender, EventArgs e)
        {
            // Set up textboxes            
            foreach (var c in Controls)
            {
                if (c is TextBox)
                {
                    textBoxes.Add((TextBox)c);
                }               
            }

            // Flow Layout Panel Settings
            alunosPanelLengths.Add(alunosFlwLayPnl.Width);
            alunosFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            alunosFlwLayPnl.AutoScroll = true;
            alunosFlwLayPnl.WrapContents = false;

            disciplinasPanelLengths.Add(disciplinasFlwLayPnl.Width);
            disciplinasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            disciplinasFlwLayPnl.AutoScroll = true;
            disciplinasFlwLayPnl.WrapContents = false;

            // Busca alunos no DB
            controladorAluno.FindAll().ForEach(a => alunos.Add(new FormularioAluno()
            {
                Id = a.Id,
                Nome = a.Nome
            }));

            // Busca disciplinas no DB
            controladorDisciplina.FindAll().ForEach(d => disciplinas.Add(new FormularioDisciplina()
            {
                Id = d.Id,
                Nome = d.Nome
            }));
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!textBoxes.Any(t => t.ForeColor == Color.LightSteelBlue))
            {
                var form = new FormularioTurma
                {
                    Nome = nomeTxtBox.Text.ToUpper(),
                    Codigo = codigoTxtBox.Text.ToUpper(),
                    FormularioDisciplinas = disciplinas.Where(d =>
                                selectedDisciplinas.Any(sd => sd == d.Nome)).ToList(),
                    FormularioAlunos = alunos.Where(d =>
                                selectedAlunos.Any(sd => sd == d.Nome)).ToList(),
                    QuantidadeAlunos = selectedAlunos.Count
                };

                // Validates form
                ValidationContext validContext = new ValidationContext(form, null, null);
                List<ValidationResult> errors = new List<ValidationResult>();

                if (!Validator.TryValidateObject(form, validContext, errors, true))
                {
                    foreach (ValidationResult result in errors)
                    {
                        MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    try
                    {
                        // Sends validated form to the controller
                        controladorTurma.Add(form);

                        // Returns to MenuDisciplina
                        _mainForm.OpenNewForm(new MenuTurma(_mainForm), sender, null, true);

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //throw error.InnerException;
                    }
                }
            }
        }

        private void addAlunoBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(alunosFlwLayPnl, alunosPanels, alunosPanelLengths,
                alunos.Select(a => a.Nome).ToList(), selectedAlunos);
        }

        private void addDisciplinaBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(disciplinasFlwLayPnl, disciplinasPanels, disciplinasPanelLengths,
                disciplinas.Select(d => d.Nome).ToList(), selectedDisciplinas);
        }

        private void disciplinasFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(disciplinasFlwLayPnl, selectedDisciplinas);
        }

        private void alunosFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(alunosFlwLayPnl, selectedAlunos);
        }

        private void nomeTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(nomeTxtBox, "Nome");
        }

        private void nomeTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(nomeTxtBox, "Nome");
        }

        private void codigoTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(codigoTxtBox, "Código");
        }

        private void codigoTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(codigoTxtBox, "Código");
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            panel2.Focus();
        }

        private void alunosLb_Click(object sender, EventArgs e)
        {
            alunosLb.Focus();
        }

        private void disciplinasLb_Click(object sender, EventArgs e)
        {
            disciplinasLb.Focus();
        }
    }
}
