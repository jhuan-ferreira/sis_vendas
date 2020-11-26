using System.Linq;

namespace sis_vendas
{
    class crudCliente
    {

        sisVendasContext dbContext = new sisVendasContext();
        Cliente cliente = new Cliente();

        public void adicionarCliente(string nome, string telefone, string email, string endereco, string documento)
        {

            if (!string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
            {
                cliente.Nome = nome;
            }

            else
            {
                return;
            }

            if (!string.IsNullOrEmpty(telefone) || string.IsNullOrWhiteSpace(telefone))
            {
                cliente.Tel = telefone;
            }

            else
            {
                return;
            }

            if (!string.IsNullOrEmpty(documento) || string.IsNullOrWhiteSpace(documento))
            {
                cliente.Documento = documento;

            }

            else
            {
                return;
            }

            var e = dbContext.logadouros.Where(p => p.Endereco == endereco).First();

            cliente.Email = email;

            cliente.enderecoId = e.LogadouroId;

            dbContext.Clientes.Add(cliente);

            dbContext.SaveChanges();
        }

    }
}
