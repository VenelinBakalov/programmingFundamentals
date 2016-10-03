using System;

class InstructionSet_broken
{
    static void Main()
    {
        string opCode = Console.ReadLine().ToLower();

        while (opCode != "end")
        {
            string[] codeArgs = opCode.Split(' ');
            long result = 0;
            switch (codeArgs[0])
            {
                case "inc":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = operandOne++;
                        break;
                    }
                case "dec":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        result = operandOne--;
                        break;
                    }
                case "add":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                case "mla":
                    {
                        int operandOne = int.Parse(codeArgs[1]);
                        int operandTwo = int.Parse(codeArgs[2]);
                        result = (long)(operandOne * operandTwo);
                        break;
                    }
            }

            Console.WriteLine(result);
            opCode = Console.ReadLine();
            codeArgs = opCode.Split(' ');
        }
    }
}