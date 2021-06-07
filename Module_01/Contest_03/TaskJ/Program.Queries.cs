using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

partial class Program
{
    private static bool ValidateQuery(string query, out string[] queryParameters)
    {
        double NumberCheck;
        queryParameters = query.Split(' ');
        bool NumberOfParameters = queryParameters.Length == 3;
        bool FirstParameter1 = queryParameters[0] == "first_name" || queryParameters[0] == "last_name" || queryParameters[0] == "group";
        bool FirstParameter2 = queryParameters[0] == "rating" || queryParameters[0] == "gpa";
        bool SecondParameter1 = queryParameters[1] == "==" || queryParameters[1] == "<>";
        bool SecondParameter2 = queryParameters[1] == ">=" || queryParameters[1] == "<=";
        bool ThirdParameter = double.TryParse(queryParameters[2], out NumberCheck);
        if (NumberOfParameters)
        {
            if (FirstParameter1)
            {
                if (SecondParameter1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (FirstParameter2 && ThirdParameter)
            {
                if (SecondParameter2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    private static List<string> ProcessQuery(string[] queryParameters, string pathToDatabase)
    {

    }
}