using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Controllers;
using SistemaEscola.Entities;
using SistemaEscola.Parsers;

namespace SistemaEscola
{
    public partial class AlunoTestForm : Form
    {
        ControladorAluno controladorAluno = new ControladorAluno();

        public AlunoTestForm()
        {
            InitializeComponent();
        }

        private void AlunoTestForm_Load(object sender, EventArgs e)
        {
            var alunos = controladorAluno.FindAll();

            foreach (Aluno aluno in alunos)
            {
                if (aluno.Id != 1 && aluno.Id != 2 && aluno.Id != 3 && aluno.Id != 4)
                {
                    
                }

                nomeBox.Items.Add(aluno.Nome);
                cpfBox.Items.Add(CpfParse.ToDigit(aluno.Cpf));
                rgBox.Items.Add(aluno.Rg);
                dataNascBox.Items.Add(aluno.DataNascimento);
                telResBox.Items.Add(PhoneNumberParse.ToDigit(aluno.TelefoneResidencial));
                telCelBox.Items.Add(PhoneNumberParse.ToMobileDigit(aluno.TelefoneCelular));
                emailBox.Items.Add(aluno.Email.ToLower());
                paiBox.Items.Add(aluno.NomePai);
                maeBox.Items.Add(aluno.NomeMae);
                respBox.Items.Add(aluno.NomeResponsavel);
                matriculaBox.Items.Add(aluno.Matricula);
                turmaBox.Items.Add(aluno.TurmaId);
                //aluno.Disciplinas.ForEach(d => disciplinasBox.Items.Add(d.Nome));
                //aluno.FaltaDisciplinas.ForEach(fd => faltasBox.Items.Add(fd.Faltas));
            }
        }
    }
}
