using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public partial class Program
{
    public static bool ParseCommandsCount(string input, out int count)
    {
        if (int.TryParse(input, out count) && count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public class Logger
    {
        public static List<string> logslist = new List<string>();
        public static void HandleCommand(string command)
        {
            if (command.StartsWith("AddLog <") && command.EndsWith(">"))
            {
                logslist.Add(command.Substring(8, command.Length - 9));
            }
            else if (command == "DeleteLastLog")
            {
                if (logslist.Count == 0)
                {
                    string[] a = { "No active logs" };
                    File.AppendAllLines("logs.log", a);
                }
                else
                {
                    logslist.RemoveAt(logslist.Count - 1);
                }
            }
            else if (command == "WriteAllLogs")
            {
                if (logslist.Count == 0)
                {
                    string[] a = { "No active logs" };
                    File.AppendAllLines("logs.log", a);
                }
                else
                {
                    File.AppendAllLines("logs.log", logslist);
                    logslist.Clear();
                }
            }
            else
            {
                string[] a = { "Incorrect input" };
                File.AppendAllLines("logs.log", a);
            }
        }
    }
}