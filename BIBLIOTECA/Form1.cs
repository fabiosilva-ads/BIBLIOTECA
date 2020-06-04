﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIOTECA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dtGrvClientes.DataSource = dalCli.Select();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.nome = txtNome.Text;
            cliente.curso = txtCurso.Text;
            cliente.dias = Convert.ToInt32(txtDias.Text);
            cliente.multa = Convert.ToSingle(txtMulta.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Insert(cliente);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idCli = Convert.ToInt32(txtID.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Delete(idCli);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.id = Convert.ToInt32(txtID.Text);
            cliente.nome = txtNome.Text;
            cliente.curso = txtCurso.Text;
            cliente.dias = Convert.ToInt32(txtDias.Text);
            cliente.multa = Convert.ToSingle(txtMulta.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Update(cliente);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();
        }
    }
}
