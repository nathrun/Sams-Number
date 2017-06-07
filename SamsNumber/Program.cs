using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;



class Solution
{
    public static int count = 0;


    static long numberOfLists(long s, int m, int d)
    {
        // Complete this function
        List<node> masterParents = new List<node>();
        for (int i = 1; i <= m; i++)
        {
            masterParents.Add(new node(0, i, s, m, d));

        }

        return count % 1000000009;
    }

    static void Main(String[] args)
    {
        //  Return the number of lists satisfying the conditions above, modulo 1000000009.
        string[] tokens_s = Console.ReadLine().Split(' ');
        long s = Convert.ToInt64(tokens_s[0]);
        int m = Convert.ToInt32(tokens_s[1]);
        int d = Convert.ToInt32(tokens_s[2]);
        long result;
        result = numberOfLists(s, m, d);
        Console.WriteLine(result);

        Console.ReadKey();      //take out when submitting!
    }
}

class node
{

    public int num;
    private node child;

    public node(long sum, int num, long target, int maxNum, int maxDiff)
    {
        this.num = num;
        if (sum + num == target)
        {
            Solution.count++;
        }
        else
        {
            for (int i = num-maxDiff; i <= num+maxDiff; i++)
            {
                while (i < 1) {i++;}

                if (i > maxNum) continue;

                if (sum+this.num+i < target)
                {
                    child = new node(sum + this.num, i, target, maxNum, maxDiff);
                }
                else if (sum + this.num + i == target)
                {
                    Solution.count++;
                }
            }//for loop

        }

    }//public constructor end



}//class end

