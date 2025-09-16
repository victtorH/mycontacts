using CreatedMVC.Data;
using CreatedMVC.Models;

namespace CreatedMVC.Repositorio
{
    public class ContatoRepositorio: IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<Models.ContatoModel> ListarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public Models.ContatoModel Deletar(Models.ContatoModel contato)
        {
            Models.ContatoModel contatoDb = BuscarPorId(contato.id);

            if (contatoDb == null) throw new System.Exception("Cotato não encontrado");
            _bancoContext.Contatos.Remove(contatoDb);
            _bancoContext.SaveChanges();
            return contatoDb;
        }

        public Models.ContatoModel Atualizar(Models.ContatoModel contato)
        {
            Models.ContatoModel contatoDb = BuscarPorId(contato.id);

            if (contatoDb == null) throw new System.Exception("Cotato não encontrado");

            contatoDb.Name = contato.Name;
            contatoDb.Email = contato.Email;
            contatoDb.tel = contato.tel;

            _bancoContext.Contatos.Update(contatoDb);
            _bancoContext.SaveChanges();
            return contatoDb;
        }

        public Models.ContatoModel Adicionar(Models.ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel BuscarPorId(int id)
        {

            return _bancoContext.Contatos.FirstOrDefault(x => x.id == id);
        }
    }
}
