using System;

internal class Hipster
{
    private int money;
    private int donate;
    public int Money { get { return money; } set { money = value; } }
    public int Donate { get { return donate; } set { donate = value; } }

    public Hipster(int money, int donate)
    {
        Money = money;
        Donate = donate;
    }

    public int GetMoney()
    {
        int res = 0;
        if (money > 0)
        {
            if (money >= donate)
            {
                money -= donate;
                res = donate;
            }
            else
            {
                res = money;
            }
        }
        return res;
    }
}