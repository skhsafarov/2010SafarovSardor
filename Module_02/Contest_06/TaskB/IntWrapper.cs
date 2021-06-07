using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IntWrapper
{
    private int Iw { get; set; }
    public IntWrapper(int number)
    {
        Iw = number;
    }

    public int FindNumberLength()
    {
        if (Iw<0)
        {
            throw new ArgumentException("Number should be non-negative.");
        }
        else
        {
            return Iw.ToString().Length;
        }
    }
}