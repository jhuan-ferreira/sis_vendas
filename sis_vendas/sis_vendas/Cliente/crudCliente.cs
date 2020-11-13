using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sis_vendas
{
    class crudCliente
    {

        sisVendasContext dbContext = new sisVendasContext();
        Cliente cliente = new Cliente();

        public void adicionarCliente(string nome, string telefone, string email, string endereco, string cpf)
        {
            dbContext.Cliente.Add(new Cliente { Nome = nome, Tel = telefone, Email = email, Endereco = endereco });

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrWhiteSpace(nome))
            {
                cliente.Nome = nome;
            }

            else if (telefone.Length >= 13 && telefone.Length <= 14)
            {

                cliente.Tel = telefone;
            }

            else if (string.IsNullOrEmpty(email) && string.IsNullOrWhiteSpace(email))
            {
                cliente.Email = email;
            }

            else if (cpf.Length >= 14 && cpf.Length <= 15)
            {
                cliente.Cpf = cpf;
            }

            dbContext.SaveChanges();
        }

    }
}
