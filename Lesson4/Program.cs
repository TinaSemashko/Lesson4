using System;

Lesson4 less = new Lesson4();
string maxVal1 = less.maxValue(1, -3, "max").ToString();
string minVal1 = less.maxValue(1, -3, "min").ToString();
Console.WriteLine($"Max value {maxVal1}, Max value {minVal1}");
string maxVal2 = less.maxValue(1, 2, -3, "max").ToString();
string minVal2 = less.maxValue(1, 2, -3, "min").ToString();
Console.WriteLine($"Max value {maxVal2}, Max value {minVal2}");

bool result, result1;
less.TrySumIfOdd(1, 2, out result);
Console.WriteLine(result);
less.TrySumIfOdd(2, 2, out result1);
Console.WriteLine(result1);

Console.WriteLine(less.Repeat("Test", 5));
Console.WriteLine(less.RepeatR("Test", 5, "Test"));
less.myString = "Test";
Console.WriteLine(less.RepeatR(less.myString, 5));
Console.WriteLine(less.RepeatR1("Test", 5));

class Lesson4 {
    public string myString = "";

    public int maxValue(int param1, int param2, string variant)
    {

        int maxVal = Math.Max(param1, param2);
        int minVal = Math.Min(param1, param2);

        if (variant == "max") return maxVal;
        if (variant == "min") return minVal;
        return 0;
    }


    public void TrySumIfOdd(int param1, int param2, out bool res)
    {
        int sum = param1 + param2;
        if (sum % 2 == 0) res = true;
        else res = false;
    }



    public int maxValue(int param1, int param2, int param3, string variant)
    {

        int maxVal = Math.Max(Math.Max(param1, param2), param3);
        int minVal = Math.Min(Math.Max(param1, param2), param3);

        if (variant == "max") return maxVal;
        if (variant == "min") return minVal;
        return 0;

    }

    public string Repeat(string str, int n)
    {
        string strRes = "";
        int i = 0;
        do { 
            strRes = strRes + str;
            i++;

        }
        while (i < n);

        return strRes;
    }

    public string RepeatR(string str, int n, string fix)
    {
        if (n>1)
        {
            return RepeatR(str + fix, --n, fix);
        }

        return str;
    }

    public string RepeatR(string str, int n) // naming not so good
    {
       
       if (n > 1)
        {
            return RepeatR(str + myString, --n);
        }

        return str;
    }

    public string RepeatR1(string str, int n)//naming not so good
    {

        if (n > 1)
        {
            return str + RepeatR1(str, --n);
        }

        return str;
    }
}
//checked
