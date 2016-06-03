using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.PlayText = "O 2 E 0.5 G 0.5 A 3 E 0.5 G 0.5";

            AbstractExpression exp = null;

            try
            {
                while (context.PlayText.Length > 0)
                {
                    string str = context.PlayText.Substring(0, 1);
                    switch (str)
                    {
                        case "O":
                            exp = new Scale();
                            break;
                        case "C":
                        case "D":
                        case "E":
                        case "F":
                        case "A":
                        case "B":
                        case "P":
                            exp = new Note();
                            break;
                    }
                    exp.Interpret(context);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
