using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bPrecise.DataAccess
{
    public interface IDbConnectionContex : IDisposable
    {
        void BeginTransaction();
        void Commit();
        IDbActionContex GetActionContext();
        IDbActionContex GetActionContext(string table);
        void RollBack();
    }
}
