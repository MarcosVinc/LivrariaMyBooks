﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_My_Books
{
    public partial class TelaLogin : Form
    {

        public TelaLogin()
        {
            InitializeComponent();

        }

        private void ChamadaDeTelaCadastroLogin_Click(object sender, EventArgs e)
        {
            TelaLoginCadastro formUC = new TelaLoginCadastro();
            this.Hide();
            formUC.Show();
        }
    }
}
