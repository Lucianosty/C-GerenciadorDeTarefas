using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gerenciamento_de_Tarefas.Program;

namespace Gerenciamento_de_Tarefas
{
    public partial class TarefasConcluidas : Form
    {
        public TarefasConcluidas()
        {
            InitializeComponent();
        }

        private void TarefasConcluidas_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Tarefa Dados in DadosTarefa.Tarefas)
            {

                if (Dados.Status == "Concluir")
                {
                    FlowLayoutPanel ReceberTarefas = new FlowLayoutPanel();
                    ReceberTarefas.AutoSize = true;
                    ReceberTarefas.FlowDirection = FlowDirection.TopDown;
                    Label Informacoes = new Label();
                    Informacoes.AutoSize = true;
                    Informacoes.Font = new Font("Arial", 15, FontStyle.Bold);



                    Informacoes.Text = $"Nome: {Dados.Nome}\nDescrição: {Dados.Descricao} ";//Template String Você pode pular linha juntando o texto e a variavel

                    ReceberTarefas.Controls.Add(Informacoes); //adicionando de forma organizada os dados da tarefa
                    flowLayoutPanel1.Controls.Add(ReceberTarefas);
                }





            }
        }
    }
}

