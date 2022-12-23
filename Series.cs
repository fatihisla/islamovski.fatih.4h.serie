using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        // in caso di errore eseguire questa riga di codice per comuncare l'errore al chiamante!!
        // throw new ArgumentException();
        
        List<string> retVal = new List<string>();
        if (sliceLength <= 0)
        {
            throw new ArgumentException();
        }
        if (numbers.Length >= sliceLength)
        {
            for (int m = 0; m < numbers.Length; m++)
            {
                retVal.Add(numbers.Substring(m, sliceLength));
                if (m == numbers.Length - sliceLength)
                {
                    break;
                }
            }
        }
        else 
        {
            throw new ArgumentException();
        }
        return retVal.ToArray();
    }
}
