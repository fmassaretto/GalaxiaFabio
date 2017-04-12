using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interface
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Incluir(TEntity obj);
        TEntity SelecionarPorId(int id);
        IEnumerable<TEntity> Selecionar();
        void Alterar(TEntity obj);
        void Excluir(TEntity obj);
    }
}
