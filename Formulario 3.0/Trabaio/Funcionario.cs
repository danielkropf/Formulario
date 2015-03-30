using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Trabaio
{
    class Funcionario
    {
        public string nome, idade, sexo, cargo, salario, email, filhos, endereco, telefone, sangue, civil;

        public string paraString()
        {
            return nome + "#" + idade + "#" + cargo + "#" + civil + "#" + email + "#" + endereco + "#" + filhos + "#" + salario + "#" + sangue + "#" + sexo + "#" + telefone;
        }

        /*public void fromString(string data) 
        {
            string[] info = data.Split('#');
            nome = info[0];
            idade = info[1];
            sexo = info[2];
            cargo = info[3];
            salario = info[4];
            email = info[5];
            filhos = info[6];
            endereco = info[7];
            telefone = info[8];
            sangue = info[9];
            civil = info[10];
        }*/
    }
}
