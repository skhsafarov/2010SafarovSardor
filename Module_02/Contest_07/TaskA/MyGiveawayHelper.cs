using System;
using System.Collections.Generic;

internal class MyGiveawayHelper
{
    private int HasPrizes { get; set; }
    public List<string> Logins { get; set; }
    public List<string> Prizes { get; set; }
    private int a = 1579;
    public MyGiveawayHelper(string[] logins, string[] prizes)
    {
        Logins = new List<string> (logins);
        Prizes = new List<string> (prizes);
        HasPrizes = prizes.Length;
    }

    public bool GetHasPrizes()
    {
        if (HasPrizes <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public (string prize,string login) GetPrizeLogin()
    {
        Asd();
        var a = Prizes[0];
        var с = this.a % Logins.Count;
        var b = Logins[с];
        Logins.RemoveAt(с);
        Prizes.RemoveAt(0);
        HasPrizes=Prizes.Count;
        return (a, b);
    }
    private void Asd()
    {
        a = ((a * a) % 1000000)/100;
    }
}   