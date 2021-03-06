﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Trabaio
{
    public partial class Formulario : Form
    {
        List<Funcionario> batata = new List<Funcionario>();
        List<string> funcionariosList = new List<string>();
        int numFuncionarios = 0;
        int numTestes = 1;
        int funcionarioCerto;
        bool func = false;
        string line;

        public Formulario()
        {
            InitializeComponent();

            System.IO.StreamReader fileSR = new System.IO.StreamReader(@"funcionarios.txt");
            
            while ((line = fileSR.ReadLine()) != null) {
                string[] info = line.Split('#');
                Debug.WriteLine(line);
                batata.Add(new Funcionario { nome = info[0], idade = info[1], cargo = info[2], civil = info[3], email = info[4], endereco = info[5], filhos = info[6], salario = info[7], sangue = info[8], sexo = info[9], telefone = info[10]});
                funcionariosList.Add(info[0]);
                ver.AutoCompleteCustomSource.Add(info[0]);
                
                numFuncionarios++;
            }
            
            
        }

        private void addFuncionario(object sender, EventArgs e)
        {
            numTestes = 0;
            for (int i = 0; i < numFuncionarios; i++) {
                if (funcionariosList[i] == nome.Text) {
                    funcionariosList[i] = nome.Text;
                    batata[i] = new Funcionario { nome = nome.Text, idade = idade.Text, cargo = cargo.Text, civil = civil.Text, email = email.Text, endereco = endereco.Text, filhos = filhos.Text, salario = salario.Text, sangue = sangue.Text, sexo = sexo.Text, telefone = telefone.Text };
                    numFuncionarios++;
                    i = numFuncionarios;
                }
                numTestes++;
            }
            if(numTestes == numFuncionarios) {
                funcionariosList.Add(nome.Text);
                batata.Add(new Funcionario { nome = nome.Text, idade = idade.Text, cargo = cargo.Text, civil = civil.Text, email = email.Text, endereco = endereco.Text, filhos = filhos.Text, salario = salario.Text, sangue = sangue.Text, sexo = sexo.Text, telefone = telefone.Text });
                numFuncionarios++;
                ver.AutoCompleteCustomSource.Add(nome.Text);
            }
        }

        private void verClick(object sender, EventArgs e)
        {
            for (int i = 0; i < numFuncionarios; i++) {
                if (funcionariosList[i] == ver.Text) {
                    funcionarioCerto = i;
                    i = numFuncionarios;
                    func = true;
                }
            }
            if (func)
            {
                nome.Text = batata[funcionarioCerto].nome;
                idade.Text = batata[funcionarioCerto].idade;
                sexo.Text = batata[funcionarioCerto].sexo;
                cargo.Text = batata[funcionarioCerto].cargo;
                salario.Text = batata[funcionarioCerto].salario;
                email.Text = batata[funcionarioCerto].email;
                filhos.Text = batata[funcionarioCerto].filhos;
                endereco.Text = batata[funcionarioCerto].endereco;
                telefone.Text = batata[funcionarioCerto].telefone;
                sangue.Text = batata[funcionarioCerto].sangue;
                civil.Text = batata[funcionarioCerto].civil;
            }
        }

        private void removerFuncionario(object sender, EventArgs e)
        {
            for (int i = 0; i < numFuncionarios; i++)
            {
                if (funcionariosList[i] == ver.Text)
                {
                    funcionarioCerto = i;
                    i = numFuncionarios;
                }
            }
            batata.Remove(batata[funcionarioCerto]);
            funcionariosList.Remove(ver.Text);
            ver.AutoCompleteCustomSource.Remove(ver.Text);
            numFuncionarios--;
        }

        private void SalvarTXT(object sender, EventArgs e)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"funcionarios.txt");
            for (int i = 0; i < numFuncionarios; i++) {
                file.WriteLine(batata[i].paraString());
            }
            file.Close();
        }

        private void limpar(object sender, EventArgs e)
        {
            nome.Text = "";
            idade.Text = "";
            sexo.Text = "";
            cargo.Text = "";
            salario.Text = "";
            email.Text = "";
            filhos.Text = "";
            endereco.Text = "";
            telefone.Text = "";
            sangue.Text = "";
            civil.Text = "";
        }
    }
}