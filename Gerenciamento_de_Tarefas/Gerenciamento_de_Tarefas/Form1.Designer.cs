namespace Gerenciamento_de_Tarefas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNovaTarefa = new Button();
            btnTarefasPen = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button2 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnNovaTarefa
            // 
            btnNovaTarefa.Anchor = AnchorStyles.Top;
            btnNovaTarefa.BackColor = Color.FromArgb(59, 130, 246);
            btnNovaTarefa.FlatAppearance.BorderSize = 0;
            btnNovaTarefa.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 185, 129);
            btnNovaTarefa.FlatStyle = FlatStyle.Flat;
            btnNovaTarefa.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold);
            btnNovaTarefa.ForeColor = Color.FromArgb(17, 24, 39);
            btnNovaTarefa.Location = new Point(189, 15);
            btnNovaTarefa.Name = "btnNovaTarefa";
            btnNovaTarefa.Size = new Size(169, 54);
            btnNovaTarefa.TabIndex = 0;
            btnNovaTarefa.Text = "Nova Tarefa";
            btnNovaTarefa.UseVisualStyleBackColor = false;
            btnNovaTarefa.Click += btnNovaTarefa_Click;
            // 
            // btnTarefasPen
            // 
            btnTarefasPen.Anchor = AnchorStyles.Top;
            btnTarefasPen.BackColor = Color.FromArgb(59, 130, 246);
            btnTarefasPen.FlatAppearance.BorderSize = 0;
            btnTarefasPen.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 185, 129);
            btnTarefasPen.FlatStyle = FlatStyle.Flat;
            btnTarefasPen.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold);
            btnTarefasPen.ForeColor = Color.FromArgb(17, 24, 39);
            btnTarefasPen.Location = new Point(356, 16);
            btnTarefasPen.Name = "btnTarefasPen";
            btnTarefasPen.Size = new Size(219, 51);
            btnTarefasPen.TabIndex = 1;
            btnTarefasPen.Text = "Tarefa Pendente";
            btnTarefasPen.UseVisualStyleBackColor = false;
            btnTarefasPen.Click += btnTarefasPen_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(59, 130, 246);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 185, 129);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(568, 21);
            button1.Name = "button1";
            button1.Size = new Size(145, 42);
            button1.TabIndex = 2;
            button1.Text = "Concluída";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(59, 130, 246);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnTarefasPen);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnNovaTarefa);
            panel2.Location = new Point(-5, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 77);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.FromArgb(59, 130, 246);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 185, 129);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(17, 24, 39);
            button2.Location = new Point(99, 15);
            button2.Name = "button2";
            button2.Size = new Size(89, 54);
            button2.TabIndex = 6;
            button2.Text = "Início";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(107, 114, 128);
            label1.Font = new Font("Microsoft Sans Serif", 23F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(17, 24, 39);
            label1.Location = new Point(-5, 0);
            label1.Name = "label1";
            label1.Size = new Size(801, 48);
            label1.TabIndex = 5;
            label1.Text = "Gerenciamento de Tarefas";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(249, 250, 251);
            panel1.Location = new Point(-3, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 417);
            panel1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            ClientSize = new Size(798, 536);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovaTarefa;
        private Button btnTarefasPen;
        private Button button1;
        private Panel panel2;
        private Label label1;
        private Button button2;
        private Panel panel1;
    }
}
