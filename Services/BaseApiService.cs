using System;
using System.Collections.Generic;
using gregslist.Repositories;

namespace gregslist.Services
{
    public abstract class BaseApiService<T, Tid>
    {
        private readonly BaseApiRepository<T, Tid> _repo;
        public BaseApiService(BaseApiRepository<T, Tid> repo)
        {
            _repo = repo;
        }

        public virtual IEnumerable<T> Get()
        {
            return _repo.Get();
        }

        public virtual T Get(Tid id)
        {
            T exists = _repo.Get(id);
            if (exists == null) { throw new Exception("Invalid Id"); }
            return exists;
        }
    }
}