using System;

partial class Program
{
    // Проверка на валидные входные данные
    private static bool ValidateData(int day, int month, int year)
    {
        string s = GetFormatMessage(day, month, year);
        DateTime dt, dt1, dt2;
        bool asd = DateTime.TryParse(s, out dt);
        dt1 = DateTime.Parse("01.01."+MinYear);
        dt2 = DateTime.Parse("31.12."+MaxYear);
        if (asd && dt >= dt1 && dt <= dt2)
            return true;
        else
            return false;
    }

    private static int GetDayOfWeek(int day, int month, int year)
    {
        string s = GetFormatMessage(day, month, year);
        DateTime dt = DateTime.Parse(s);      
        return (int)dt.DayOfWeek;
    }

    private static string GetDateOfFriday(int dateOfWeek, int day, int month, int year)
    {
        string s = GetFormatMessage(day, month, year);
        DateTime date = DateTime.Parse(s);
        int i;
        for(i=0; i<=6; i++)
        {
            if(date.AddDays(i).DayOfWeek==DayOfWeek.Friday)
            {
                date = date.AddDays(i);
            }
        }
        s = GetFormatMessage((int)date.Day, (int)date.Month, (int)date.Year);
        return s;
    }
}