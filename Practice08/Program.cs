/*Develop a sub-algorithm with two parameters, message of type string and count of type number; 
 the algorithm should return a line consisting of the message concatenated count times joined by a space.
	- Example: given "sun" and 6 => "sun sun sun sun sun sun"
	- Example: given "moon" and 3 => "moon moon moon" */


using System;

class Program8
{
    private void msgRepeat(string input_msg, int input_cnt)
    {
        string msgs = input_msg;

        msgs = string.Concat(Enumerable.Repeat(input_msg + ' ', input_cnt));

        Console.WriteLine("\n" + msgs);
    }

    static void Main(string[] args)
    {
        Program8 p = new Program8();

        string msginput, cntinput;
        int cntNum=0;

        Console.Write("Input a message(one word): ");
        msginput = Console.ReadLine();
        Console.Write("Input a number how many times you want to repeat: ");
        cntinput = Console.ReadLine();
        cntNum = Convert.ToInt32(cntinput);
 
        p.msgRepeat(msginput, cntNum);
    }
}