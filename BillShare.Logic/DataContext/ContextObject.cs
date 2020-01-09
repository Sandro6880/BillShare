//@BaseCode
//MdStart
using BillShare.Contracts;
using BillShare.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BillShare.Logic.DataContext
{
    class ContextObject
    {
        internal abstract partial class ContextObject : IContext
        {
            public ContextObject()
            {
            }
            #region Async-Methods
            public abstract Task<int> CountAsync<I, E>()
                where I : IIdentifiable
                where E : IdentityObject, I;
            public abstract Task<E> CreateAsync<I, E>()
                where I : IIdentifiable
                where E : IdentityObject, I, ICopyable<I>, new();
            public abstract Task<E> InsertAsync<I, E>(I entity)
                where I : IIdentifiable
                where E : IdentityObject, ICopyable<I>, I, new();
            public abstract Task<E> UpdateAsync<I, E>(I entity)
                where I : IIdentifiable
                where E : IdentityObject, I, ICopyable<I>, new();
            public abstract Task<E> DeleteAsync<I, E>(int id)
                where I : IIdentifiable
                where E : IdentityObject, I;
            public abstract Task SaveAsync();

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public override string ToString()
            {
                return base.ToString();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
            #endregion Async-Methods
        }
    }
}
