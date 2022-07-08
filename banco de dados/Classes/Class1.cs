using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco_de_dados.Classes
{
    public class Cliente
    {
        public string Nome;
        public string Telefone;
        public string CPF;
        public void Gravar()
        {
            var clientes = Cliente.LerCLientes();
            clientes.Add(this);
            if (File.Exists(dBClinetes()))
            {
                string conteudo = "nome;telefone;cpf;\n";
                foreach (Cliente c in clientes)
                {
                    conteudo += c.Nome;
                }
            }
        }

        private static string dBClinetes()
        {
            return @"C:\db\clientes.txt";
        }


        public static List<Cliente> LerCLientes()
        {

            var clientes = new List<Cliente>();
            


            if (File.Exists(dBClinetes()))
            {

                using (StreamReader arquivo = File.OpenText(dBClinetes()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var clienteArquivo = linha.Split(';');

                        var cliente = new Cliente { CPF = clienteArquivo[1], Nome = clienteArquivo[0], Telefone = clienteArquivo[2] };


                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }

        

    }
}

