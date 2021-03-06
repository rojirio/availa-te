﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avaliate
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            greetingMessage.Text = "Bem Vindo(a), " + LoginInfo.nome;
        }

        private void cadastrarQuestoes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var cadastrarQuestoes = new CadastroQuestao();
            cadastrarQuestoes.Closed += (s, args) => this.Close();
            cadastrarQuestoes.Show();
        }

        private void montarProva_Click(object sender, EventArgs e)
        {
            this.Hide();
            var montagemProva = new MontagemProva();
            montagemProva.Closed += (s, args) => this.Close();
            montagemProva.Show();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            this.Hide();
            var index = new Index();
            index.Closed += (s, args) => this.Close();
            index.Show();
        }
    }
}
