using System;

class Kikstarter
{
    // Данный тип необходимо обязательно использовать
    public delegate int GetMoneyDelegate();

    GetMoneyDelegate[] getMoney;
    private int m;
    public int M { get { return m; } set { m = value; } }

    public Kikstarter(int m, Hipster[] hipsters)
    {
        if (hipsters.Length == 0 && hipsters.GetType().ToString() == "Hipster[]")
        {
            throw new ArgumentException("Not enough hipsters");
        }
        int sum = 0;
        for (int i = 0; i < hipsters.Length; i++)
        {
            sum += hipsters[i].Money;
        }
        if (sum < m)
        {
            throw new InvalidOperationException("Not enough money");
        }
        M = m;
        getMoney = new GetMoneyDelegate[hipsters.Length];
        for (int i = 0; i < hipsters.Length; i++)
        {
            getMoney[i] = hipsters[i].GetMoney;
        }
    }

    public int Run()
    {
        int m1 = 0;
        int res = 0;
        for (int i = 0; true; i++)
        {
            for (int j = 0; j < getMoney.Length; j++)
            {
                m1 += getMoney[j]();
            }
            if (m1 >= M)
            {
                res = i + 1;
                break;
            }
        }
        return res;
    }
}