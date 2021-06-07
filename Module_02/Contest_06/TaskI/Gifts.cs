using System;

public static class GiftCreator
{
    static int a;
    static int b;
    public static Gift CreateGift(string giftName)
    {
        if (giftName == "PlayStation")
        {
            PlayStation p1 = new PlayStation(a);
            a += 1;
            return p1;
        }
        else if (giftName == "Phone")
        {
            Phone p2 = new Phone(b);
            b += 1;
            return p2;
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
    }
}

public class Phone : Gift
{
    public Phone(int id) : base(id) => ID = id;
}

public class PlayStation : Gift
{
    public PlayStation(int id) : base(id) => ID = id;
}