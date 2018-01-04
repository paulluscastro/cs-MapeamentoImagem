using System.Drawing;
using System.Windows.Forms;
using MapeamentoImagem.Classes;
using System.Data.Entity;
using System;

namespace MapeamentoImagem
{
    public partial class Form1 : Form
    {
        private Crianca Crianca { get; set; }
        private bool Edicao { get; set; }
        private DataContext Contexto { get; set; }

        public Form1()
        {
            InitializeComponent();
            Contexto = new DataContext();
            dataGridView1.DataSource = Contexto.Criancas.Local.ToBindingList();
            HabilitaDesabilita(habilitarEdicao: false);
        }

        private void Limpar()
        {
            txtNome.Clear();
            txtNomeMae.Clear();
            imgEsquerdo.Image = Properties.Resources.esquerdo;
            imgDireito.Image = Properties.Resources.direito;
        }

        private void PrintarPonto(Pe pe)
        {
            PictureBox pic = pe.Lado == Lado.Esquerdo ? imgEsquerdo : imgDireito;
            Image imagem = pic.Image;
            using (Graphics graphics = Graphics.FromImage(imagem))
            {
                Pen pen = new Pen(Color.Red, 3);
                graphics.DrawEllipse(pen, pe.X, pe.Y, 3, 3);
                pic.Image = imagem;
            }
        }

        private void HabilitaDesabilita(bool habilitarEdicao)
        {
            dataGridView1.Enabled = !habilitarEdicao;
            toolStrip1.Enabled = !habilitarEdicao;
            txtNome.ReadOnly = !habilitarEdicao;
            txtNomeMae.ReadOnly = !habilitarEdicao;
            btnConfirmar.Visible = habilitarEdicao;
            btnCancelar.Visible = habilitarEdicao;
            Edicao = habilitarEdicao;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            Crianca = null;
            txtNome.Clear();
            txtNomeMae.Clear();
            HabilitaDesabilita(habilitarEdicao: false);
        }

        private void btnConfirmar_Click(object sender, System.EventArgs e)
        {
            Crianca.Id = Guid.NewGuid();
            Crianca.Nome = txtNome.Text;
            Crianca.NomeMae = txtNomeMae.Text;
            Contexto.Criancas.Add(Crianca);
            Contexto.SaveChanges();
            dataGridView1.DataSource = Contexto.Criancas.Local.ToBindingList();
            HabilitaDesabilita(habilitarEdicao: false);
        }

        private void dataGridView1_SelectionChanged(object sender, System.EventArgs e)
        {
            Limpar();
            if ((dataGridView1.SelectedRows.Count == 0) || (dataGridView1.SelectedRows[0].DataBoundItem == null)) return;
            Crianca = (Crianca)dataGridView1.SelectedRows[0].DataBoundItem;
            txtNome.Text = Crianca.Nome;
            txtNomeMae.Text = Crianca.NomeMae;
            foreach (Pe pe in Crianca.Pontos)
                PrintarPonto(pe);
        }

        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            if ((!Edicao) || (e.Button != MouseButtons.Left)) return;

            Pe pe = new Pe()
            {
                Id = Guid.NewGuid(),
                Lado = sender == imgEsquerdo ? Lado.Esquerdo : Lado.Direito,
                X = e.X,
                Y = e.Y
            };
            Crianca.Pontos.Add(pe);
            PrintarPonto(pe);
        }

        private void tsbNova_Click(object sender, System.EventArgs e)
        {
            Limpar();
            Crianca = new Crianca();
            HabilitaDesabilita(habilitarEdicao: true);
        }
    }
}
