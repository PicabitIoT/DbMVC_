using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IDbCon
{
    string SelectString(string query);
    bool ExecuteCommand(string query);
    bool ExecuteMultiCommand(string query);
    object ExecuteScalar(string query);
    DataTable SelectDataTable(string query);//<<<
    bool SelectDataTable(string query, out DataTable dataTable);
    string ReadCell(string sql, string column);
    string IdNext(string table);
    bool ExecuteStoreProcedure(string namestoreprocedure);
    DataTable SelectDataTableFromStoreProcedure(string namestoreprocedure);
}
