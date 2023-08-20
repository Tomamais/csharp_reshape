// C# code​​​​​​‌​‌​​​‌‌‌​‌​​​​‌​‌‌‌​‌‌​​ below
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

class Solution
{
    public static String Reshape(int n, String str)
    {
        // clean up 
        str = str.Replace(" ", "");
        StringBuilder result = new StringBuilder();
        int control = n;

        foreach (char character in str)
        {
            if (control > 1)
            {
                control--;
                result.Append(character);
            }
            else
            {
                result.AppendLine(character.ToString());
                control = n;
            }
        }

        return result.ToString();
    }
}