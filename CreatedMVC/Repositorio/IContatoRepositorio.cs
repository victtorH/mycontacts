using CreatedMVC.Models;

namespace CreatedMVC.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> ListarTodos();
        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel BuscarPorId(int id);

        ContatoModel Deletar(ContatoModel contato);

        ContatoModel Atualizar(ContatoModel contato);
    }
}
