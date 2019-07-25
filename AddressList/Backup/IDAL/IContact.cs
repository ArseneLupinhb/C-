using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using IDAL;
namespace IDAL
{
    public interface IContact
    {
        int GetContactCountByGroupId(int groupId);
        DataTable GetList(string strWhere);
        bool Add(Model.Contact model);
        bool Delete(int Id);
        bool Update(Model.Contact model);
        Model.Contact GetModel(int Id);
    }
}
