﻿using Dominio.Interface;
using Galaxia.Dados.Contexto;
using Galaxia.Dados.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxia.Dados.Repositorio
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        protected GalaxiaContext _db = new GalaxiaContext();
        public void Alterar(TEntity obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Excluir(TEntity obj)
        {
            _db.Entry(obj).State = EntityState.Deleted;
            _db.Set<TEntity>().Remove(obj);
            _db.SaveChanges();
        }

        public void Incluir(TEntity obj)
        {
            _db.Set<TEntity>().Add(obj);
            _db.SaveChanges();
        }

        public IEnumerable<TEntity> Selecionar()
        {
            return _db.Set<TEntity>().ToList();
        }

        public TEntity SelecionarPorId(int id)
        {
            return _db.Set<TEntity>().Find(id);
        }
    }
}
