using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void Print(string line);

class Logger
{
    List<LogPair> list = new List<LogPair>();

    public void OutputLogs()
    {
        foreach (var i in list)
        {
            Console.WriteLine(i.Log);
        }
    }

    public void MakeLog(Print method, string line)
    {
        if (method == Console.WriteLine)
        {
            list.Add(new LogPair(method, line));
        }
        else
        {
            method(line);
        }
    }
}