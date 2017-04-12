using Dominio;
using Dominio.Interface;
using Galaxia.Dados.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia.Negocios
{
    public class PlanetaNG : IRepositorioBase<Planeta>
    {
        private RepositorioBase<Planeta> _repositorio;
        public PlanetaNG()
        {

        }
        public void Alterar(Planeta obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Planeta obj)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Planeta obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Planeta> Selecionar()
        {
            return _repositorio.Selecionar();
        }

        public Planeta SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
