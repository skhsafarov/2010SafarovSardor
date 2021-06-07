using System;

public class Field
{
    public int[][] Matrix { get; set; }
    public Field(int[][] matrix)
    {
        Matrix = matrix;
    }

    public void FillIn(string fillType)
    {
        if (fillType == "left to right")
        {
            for (int i = 0; i < Matrix.Length; i++)
            {
                Matrix[i] = new int[Matrix.Length];
                for (int j = 0; j < Matrix.Length; j++)
                {
                    Matrix[i][j] = i + j+1;
                }
            }
        }
        else if (fillType == "right to left")
        {
            for (int i = 0; i < Matrix.Length; i++)
            {
                Matrix[i] = new int[Matrix.Length];
                for (int j = 0; j < Matrix.Length; j++)
                {
                    Matrix[i][Matrix.Length - j-1] = i + j + 1;
                }
            }
        }
        else
        {
            throw new ArgumentException("Incorrect input");
        }
    }
    public override string ToString()
    {
        string a = "";
        for (int i = 0; i < Matrix.Length; i++)
        {
            for (int j = 0; j < Matrix.Length; j++)
            {
                a += $"{Matrix[i][j]} ";
            }
            a += "\n";
        }
        return a;
    }
}