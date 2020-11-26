using System.Linq;
using sis_vendas.Model;

namespace sis_vendas
{
    class crudEndereco
    {
        sisVendasContext dbContext = new sisVendasContext();

        Bairro bairro = new Bairro();
        Cidade cidade = new Cidade();
        Estado estado = new Estado();
        Logadouro logadouro = new Logadouro();

        public void AdicionarCep(string cep)
        {
            dbContext.logadouros.Add(new Logadouro { Cep = cep });
            dbContext.SaveChanges();
        }

        public void adicionarBairro(string bairroNome)
        {

            try
            {
                bairro = dbContext.Bairros.Where(p => p.Nome.Contains(bairroNome)).FirstOrDefault();

                if (bairro == null)
                {
                    dbContext.Bairros.Add(new Bairro { Nome = bairroNome });

                    dbContext.SaveChanges();
                }
            }

            catch
            {
                return;
            }

        }


        public void adicionarCidade(string cidadeNome)
        {
            cidade = dbContext.Cidades.Where(p => p.Nome == cidadeNome).FirstOrDefault();

            try
            {

                if (!dbContext.Cidades.Contains(cidade))
                {
                    dbContext.Cidades.Add(new Cidade { Nome = cidadeNome });
                    dbContext.SaveChanges();
                }
            }

            catch
            {
                return;
            }

        }

        public void adicionaEstado(string estadoNome)
        {
            estado = dbContext.Estados.Where(p => p.Nome == estadoNome).FirstOrDefault();

            try
            {

                if (!dbContext.Estados.Contains(estado))
                {
                    dbContext.Estados.Add(new Estado { Nome = estadoNome });
                    dbContext.SaveChanges();
                }
            }

            catch
            {
                return;
            }

        }

        public void adicionaLogadouro(string enderecoNome, string bairroNome, string estadoNome, string cidadeNome, string cep, int numero )
        {

            bairro = dbContext.Bairros.Where(p => p.Nome == bairroNome).First();
            estado = dbContext.Estados.Where(p => p.Nome == estadoNome).First();
            cidade = dbContext.Cidades.Where(p => p.Nome == cidadeNome).First();

            logadouro.Numero = numero;
            logadouro.Endereco = enderecoNome;
            logadouro.Cep = cep;
            logadouro.BairroId = bairro.BairroId;
            logadouro.EstadoId = estado.EstadoId;

            logadouro.CidadeId = cidade.CidadeId;

            logadouro =  dbContext.logadouros.Where(p => p.Cep == logadouro.Cep && p.Numero == logadouro.Numero).FirstOrDefault();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          

            if (logadouro == null)
            {
                dbContext.logadouros.Add(logadouro);
                dbContext.SaveChanges();
            }


        }

    }
}