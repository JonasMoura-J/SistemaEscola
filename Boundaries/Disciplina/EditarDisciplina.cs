﻿using System;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SistemaEscola.Entities.Formularios;
using SistemaEscola.Controllers;
using SistemaEscola.Utils;

namespace SistemaEscola
{
    public partial class EditarDisciplina : Form
    {
        readonly Home _mainForm;
        readonly bool _returnPrevious;

        readonly ControladorDisciplina controladorDisciplina = ControladorDisciplina.Instance;
        readonly ControladorProfessor controladorProfessor = ControladorProfessor.Instance;
        readonly ControladorTurma controladorTurma = ControladorTurma.Instance;

        readonly List<NamePanel> professoresPanels = new List<NamePanel>();
        readonly List<int> professoresPanelLengths = new List<int>();
        readonly List<NamePanel> turmasPanels = new List<NamePanel>();
        readonly List<int> turmasPanelLengths = new List<int>();

        readonly FormularioDisciplina disciplina;

        readonly List<FormularioProfessor> professores = new List<FormularioProfessor>();
        readonly List<FormularioTurma> turmas = new List<FormularioTurma>();

        public readonly List<string> selectedProfessores = new List<string>();
        public readonly List<string> selectedTurmas = new List<string>();

        public EditarDisciplina(Home mainForm, FormularioDisciplina form, bool returnPrevious = false)
        {
            InitializeComponent();
            _mainForm = mainForm;
            disciplina = form;
            _returnPrevious = returnPrevious;
        }

        private void EditarDisciplina_Load(object sender, EventArgs e)
        {
            // Set up Disciplina
            var tempDisciplina = controladorDisciplina.FindById(disciplina.Id);

            disciplina.Nome = tempDisciplina.Nome;


            // Set up Professores
            professoresPanelLengths.Add(professoresFlwLayPnl.Width);
            professoresFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            professoresFlwLayPnl.AutoScroll = true;
            professoresFlwLayPnl.WrapContents = false;

            controladorProfessor.FindAll().ForEach(p => professores.Add(new FormularioProfessor()
            {
                Id = p.Id,
                Nome = p.Nome
            }));

            var professorDisciplinas = controladorDisciplina
                .FindAllProfessorDisciplinaByDisciplina(disciplina.Id);

            if (professorDisciplinas.Any())
            {
                foreach (var prof in professores)
                {
                    foreach (var profDisc in professorDisciplinas)
                    {
                        if (prof.Id == profDisc.ProfessorId)
                        {
                            selectedProfessores.Add(prof.Nome);
                        }
                    }
                }

                foreach (var prof in selectedProfessores)
                {
                    var panel = new NamePanel(prof, professoresFlwLayPnl);

                    professoresPanels.Add(panel);
                    professoresFlwLayPnl.Controls.Add(panel);

                    professoresPanelLengths.Add(panel.Width);
                    panel.AutoSize = false;
                    professoresPanels.ForEach(p => p.Width = professoresPanelLengths.Max());
                }
            }

            // Set up Turmas
            turmasPanelLengths.Add(turmasFlwLayPnl.Width);
            turmasFlwLayPnl.FlowDirection = FlowDirection.TopDown;
            turmasFlwLayPnl.AutoScroll = true;
            turmasFlwLayPnl.WrapContents = false;

            controladorTurma.FindAll().ForEach(t => turmas.Add(new FormularioTurma()
            {
                Id = t.Id,
                Nome = t.Nome
            }));

            var turmaDisciplinas = controladorDisciplina
                .FindAllTurmaDisciplinaByDisciplina(disciplina.Id);

            if (turmaDisciplinas.Any())
            {
                foreach (var turma in turmas)
                {
                    foreach (var turmaDisc in turmaDisciplinas)
                    {
                        if (turma.Id == turmaDisc.TurmaId)
                        {
                            selectedTurmas.Add(turma.Nome);
                        }
                    }
                }

                foreach (var turma in selectedTurmas)
                {
                    var panel = new NamePanel(turma, turmasFlwLayPnl);

                    turmasPanels.Add(panel);
                    turmasFlwLayPnl.Controls.Add(panel);

                    turmasPanelLengths.Add(panel.Width);
                    panel.AutoSize = false;
                    turmasPanels.ForEach(p => p.Width = turmasPanelLengths.Max());
                }
            }

            // Text box
            nomeTxtBox.Text = disciplina.Nome;
            nomeTxtBox.ForeColor = Color.Black;
        }

        private void concluirBtn_Click(object sender, EventArgs e)
        {
            // Check if Nome is empty
            if (nomeTxtBox.ForeColor != Color.LightSteelBlue)
            {
                // Creates form to be sent to controller
                var form = new FormularioDisciplina
                {
                    Id = disciplina.Id,
                    Nome = nomeTxtBox.Text.ToUpper(),
                    FormularioProfessores = professores.Where(p =>
                        selectedProfessores.Any(sp => sp == p.Nome)).ToList(),
                    FormularioTurmas = turmas.Where(t =>
                        selectedTurmas.Any(st => st == t.Nome)).ToList()
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
                        controladorDisciplina.Update(form);

                        if (_returnPrevious)
                        {
                            // Returns to previous form (always ListarDisciplina) (since couldn't fix error)
                            _mainForm.OpenNewForm(new MenuDisciplina(_mainForm), sender, null, true);
                            _mainForm.OpenNewForm(new ListarDisciplinas(_mainForm), sender, null);
                        }
                        else
                        {
                            // Returns to MenuDisciplina
                            _mainForm.OpenNewForm(new MenuDisciplina(_mainForm), sender, null, true);
                        }

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //throw error.InnerException;
                    }
                }
            }
        }

        private void addProfessorBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(professoresFlwLayPnl, professoresPanels, professoresPanelLengths,
                professores.Select(p => p.Nome).ToList(), selectedProfessores);
        }

        private void addTurmaBtn_Click(object sender, EventArgs e)
        {
            FlowLayoutPanelTools.InsertItems(turmasFlwLayPnl, turmasPanels, turmasPanelLengths,
                turmas.Select(t => t.Nome).ToList(), selectedTurmas);
        }

        private void professoresFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(professoresFlwLayPnl, selectedProfessores);
        }

        private void turmasFlwLayPnl_ControlRemoved(object sender, ControlEventArgs e)
        {
            FlowLayoutPanelTools.UpdateList(turmasFlwLayPnl, selectedTurmas);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var confirmScreen = new ConfirmDeletion("disciplina");
            confirmScreen.ShowDialog();

            if (confirmScreen.Confirmation)
            {
                controladorDisciplina.Delete(disciplina.Id);

                if (_returnPrevious)
                {
                    // Returns to previous form (always ListarDisciplina)
                    _mainForm.OpenNewForm(new MenuDisciplina(_mainForm), sender, null, true);
                    _mainForm.OpenNewForm(new ListarDisciplinas(_mainForm), sender, null);
                }
                else
                {
                    // Returns to MenuDisicplina
                    _mainForm.OpenNewForm(new MenuDisciplina(_mainForm), sender, null, true);
                }
            }
        }

        private void nomeTxtBox_Enter(object sender, EventArgs e)
        {
            TextBoxTools.Clear(nomeTxtBox, "Nome");
        }

        private void nomeTxtBox_Leave(object sender, EventArgs e)
        {
            TextBoxTools.Fill(nomeTxtBox, "Nome");
        }
    }
}
