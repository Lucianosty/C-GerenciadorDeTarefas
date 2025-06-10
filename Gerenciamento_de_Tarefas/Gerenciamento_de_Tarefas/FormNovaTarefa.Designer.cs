namespace Gerenciamento_de_Tarefas
{
    partial class FormNovaTarefa
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
            label1 = new Label();
            tbNomeTarefa = new TextBox();
            label2 = new Label();
            DescricaoTarefa = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(241, 49);
            label1.Name = "label1";
            label1.Size = new Size(329, 25);
            label1.TabIndex = 0;
            label1.Text = "Digite o nome da sua nova tarefa";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbNomeTarefa
            // 
            tbNomeTarefa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbNomeTarefa.BorderStyle = BorderStyle.FixedSingle;
            tbNomeTarefa.Location = new Point(199, 88);
            tbNomeTarefa.Name = "tbNomeTarefa";
            tbNomeTarefa.Size = new Size(394, 23);
            tbNomeTarefa.TabIndex = 1;
            tbNomeTarefa.TextChanged += tbNomeTarefa_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(17, 24, 39);
            label2.Location = new Point(293, 129);
            label2.Name = "label2";
            label2.Size = new Size(207, 25);
            label2.TabIndex = 2;
            label2.Text = "Descrição da Tarefa";
            // 
            // DescricaoTarefa
            // 
            DescricaoTarefa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescricaoTarefa.BorderStyle = BorderStyle.FixedSingle;
            DescricaoTarefa.Location = new Point(199, 163);
            DescricaoTarefa.Multiline = true;
            DescricaoTarefa.Name = "DescricaoTarefa";
            DescricaoTarefa.Size = new Size(394, 174);
            DescricaoTarefa.TabIndex = 3;
            DescricaoTarefa.TextChanged += DescricaoTarefa_TextChanged;
            // 
            // btnEnviar
            // 
            btnEnviar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEnviar.BackColor = Color.FromArgb(59, 130, 246);
            btnEnviar.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 185, 129);
            btnEnviar.FlatStyle = FlatStyle.Flat;
            btnEnviar.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            btnEnviar.ForeColor = Color.FromArgb(17, 24, 39);
            btnEnviar.Location = new Point(341, 353);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(101, 37);
            btnEnviar.TabIndex = 4;
            btnEnviar.Text = "Salvar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // FormNovaTarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(DescricaoTarefa);
            Controls.Add(label2);
            Controls.Add(tbNomeTarefa);
            Controls.Add(label1);
            Name = "FormNovaTarefa";
            Text = "FormNovaTarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNomeTarefa;
        private Label label2;
        private TextBox DescricaoTarefa;
        private Button btnEnviar;
    }
}