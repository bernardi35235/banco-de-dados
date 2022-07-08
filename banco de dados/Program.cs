using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using banco_de_dados;
using banco_de_dados.Classes;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {

           var clientes = Cliente.LerCLientes();
         

            var cliente = new Cliente
            {
                Nome = "danilo",
                CPF = "1232313123",
                Telefone = "123861283"
            };
            var cliente2 = new Cliente
            {
                Nome = "roberto",
                CPF = "1232313123",
                Telefone = "123861283"
            };

            //foreach (Cliente c in clientes)
            {
                //Console.WriteLine(c.Nome);
            }

            
            
        }
    }
}
