using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DbConControler
{
    private readonly IDbCon _dbCon;

    public DbConControler(IDbCon dbCon)
    {
        _dbCon = dbCon;
    }


    public DataTable SelectDataTable(string query)
    {
        return _dbCon.SelectDataTable(query);
    }
}
