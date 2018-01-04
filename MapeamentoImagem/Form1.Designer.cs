namespace MapeamentoImagem
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.lbNomeMae = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNova = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imgEsquerdo = new System.Windows.Forms.PictureBox();
            this.imgDireito = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEsquerdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDireito)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(12, 269);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(88, 13);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome da criança";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 285);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(335, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Location = new System.Drawing.Point(356, 285);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(335, 20);
            this.txtNomeMae.TabIndex = 4;
            // 
            // lbNomeMae
            // 
            this.lbNomeMae.AutoSize = true;
            this.lbNomeMae.Location = new System.Drawing.Point(353, 269);
            this.lbNomeMae.Name = "lbNomeMae";
            this.lbNomeMae.Size = new System.Drawing.Size(73, 13);
            this.lbNomeMae.TabIndex = 3;
            this.lbNomeMae.Text = "Nome da mãe";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(356, 311);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(437, 311);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNova});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(702, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNova
            // 
            this.tsbNova.Image = ((System.Drawing.Image)(resources.GetObject("tsbNova.Image")));
            this.tsbNova.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNova.Name = "tsbNova";
            this.tsbNova.Size = new System.Drawing.Size(119, 22);
            this.tsbNova.Text = "Nova criança (F1)";
            this.tsbNova.Click += new System.EventHandler(this.tsbNova_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(702, 241);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome da criança";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 104;
            // 
            // NomeMae
            // 
            this.NomeMae.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeMae.HeaderText = "Nome da mãe";
            this.NomeMae.Name = "NomeMae";
            this.NomeMae.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // imgEsquerdo
            // 
            this.imgEsquerdo.Image = ((System.Drawing.Image)(resources.GetObject("imgEsquerdo.Image")));
            this.imgEsquerdo.Location = new System.Drawing.Point(15, 311);
            this.imgEsquerdo.Name = "imgEsquerdo";
            this.imgEsquerdo.Size = new System.Drawing.Size(146, 200);
            this.imgEsquerdo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEsquerdo.TabIndex = 0;
            this.imgEsquerdo.TabStop = false;
            this.imgEsquerdo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseDown);
            // 
            // imgDireito
            // 
            this.imgDireito.Image = ((System.Drawing.Image)(resources.GetObject("imgDireito.Image")));
            this.imgDireito.Location = new System.Drawing.Point(204, 311);
            this.imgDireito.Name = "imgDireito";
            this.imgDireito.Size = new System.Drawing.Size(146, 200);
            this.imgDireito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDireito.TabIndex = 1;
            this.imgDireito.TabStop = false;
            this.imgDireito.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBoxMouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 534);
            this.Controls.Add(this.imgEsquerdo);
            this.Controls.Add(this.imgDireito);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtNomeMae);
            this.Controls.Add(this.lbNomeMae);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.MinimumSize = new System.Drawing.Size(718, 573);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEsquerdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDireito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.Label lbNomeMae;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNova;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMae;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox imgDireito;
        private System.Windows.Forms.PictureBox imgEsquerdo;
    }
}

