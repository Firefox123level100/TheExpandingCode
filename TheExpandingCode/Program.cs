using Microsoft.VisualBasic;

namespace TheExpandingCode
{
    internal class Program
    {
/*

### Problem: **The Expanding Code**

Consider a string generation game based on simple substitution rules:

* Every occurrence of the letter**`A`** becomes**`AB`**.
* Every occurrence of the letter**`B`** becomes**`A`**.

You start with the single character **`A`** at Step 0.Let's look at the first few steps:

* **Step 0:** `A` (length 1)
* **Step 1:** `AB` (length 2)
* **Step 2:** `ABA` (length 3)
* **Step 3:** `ABAAB` (length 5)
* **Step 4:** `ABAABABA` (length 8)

Notice that the length of the string grows following the Fibonacci sequence!If you tried to generate the actual string for 50 steps, it would be billions of characters long and cause an immediate * *Out of Memory** crash.

#### Your Task

Write a program(in C# or whatever language you prefer) that takes a 1-indexed position **$K$** (where $1 \le K \le 10^{15}$) and a target step number (or assumes enough expansions to reach position $K$), and determines **which character (`A` or `B`) is at position $K$**.


*/

        public static long SumLength(long a, long b)
        {
            return a + b;
        }

        public static string SumStrings(string a, string b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.Write("Whats the index value: ");
            long Index = Convert.ToInt64(Console.ReadLine()) -1;

            string String = "ab";
            long OldNumber = 1;
            long NewNumber = 1;
            long TempNumber;

            while (Index > String.Length)
            {
                Index -= NewNumber;

                TempNumber = NewNumber;
                NewNumber = NewNumber + OldNumber;
                OldNumber = TempNumber;
            }

            Console.WriteLine(String[Convert.ToInt32(Math.Abs(Index)) - 1]);
        }
    }
}
