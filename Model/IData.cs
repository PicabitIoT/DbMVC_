using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IData //contratos
{
    //App
    string GetAppName();
    void SetAppName(string _AppName); // Set
    string GetAppRoute();
    string GetAppVersion();
    string GetAppYear();
    string GetLoggerRoute();
    int GetLoggerLevel();

    //DbCon
    string GetChain1();


}
