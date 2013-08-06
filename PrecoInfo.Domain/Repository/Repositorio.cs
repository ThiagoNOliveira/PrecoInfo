using NHibernate;
using NHibernate.Criterion;
using PrecoInfo.Core.Domain.Repository;
using PrecoInfo.Domain;
using System;
using System.Collections.Generic;

namespace ProcuraFacil.Core.Domain.Repository
{
    /// <summary>
    /// Repositório concreto genérico
    /// </summary>
    /// <typeparam name="T">Tipo do Repositório</typeparam>
    public class Repositorio<T> : BaseRepository, IRepositorio<T>
    {
        public Repositorio()
        {

        }

        public Repositorio(ISession session)
            : base(session)
        {

        }

        public void Adicionar(IAggregateRoot<Guid> entidade)
        {
            base.Salvar(entidade);
        }

        public void AdicionarLista(List<IAggregateRoot<Guid>> entidades)
        {
            base.SalvarLista(entidades);
        }

        public void Remover(IAggregateRoot<Guid> entidade)
        {
            base.Deletar(entidade);
        }

        public T PorId(Guid id)
        {
            return base.Obter<T>(id);
        }

        public IList<T> Todos()
        {
            return base.Todos<T>();
        }

        public IList<T> Todas()
        {
            return base.Todos<T>();
        }
	}
}
