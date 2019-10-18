using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace gregslist.Repositories
{
    public abstract class BaseApiRepository<T, Tid>
    {
        private readonly IDbConnection _db;
        private readonly string _table;
        public BaseApiRepository(IDbConnection db, string tablename)
        {
            _db = db;
            _table = tablename;
        }
        internal IEnumerable<T> Get()
        {
            string sql = $"SELECT * FROM {_table}";
            return _db.Query<T>(sql);
        }
        internal T Get(Tid id)
        {
            string sql = $"SELECT * FROM {_table} WHERE id = @id";
            return _db.QueryFirstOrDefault<T>(sql, new { id });
        }
    }
}