using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace bPrecise.DataAccess
{
    public interface IDbActionContex : IDisposable
    {
        void AddOrGroup(string field, IEnumerable values);
        void AddOrGroupText(string field, IEnumerable values);
        void AddWhereField(string field, object value);
        void AddWhereSqlText(string sql);
        void AddWhereSqlTextFormat(string format, params object[] parameters);
        void AddOrSqlText(string sql);
        void AddOrSqlTextFormat(string format, params object[] parameters);
        List<T> Get<T>();
        T GetSingle<T>();
        DataTable GetTable();
        void SetQuery(string query);
        void SetTable(string table);
    }
}
