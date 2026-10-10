

partial class Program
{
    static void LoopControlExamples()
    {

        // Break
        // for (int i = 0; i < 10; i++)
        // {
        //     if (i == 5)
        //     {
        //         break;
        //     }
        //     WriteLine(i);
        // }

        // Continue
        // for (int i = 0; i < 10; i++)
        // {
        //     if (i == 5 || i == 7)
        //     {
        //         continue;
        //     }
        //     WriteLine(i);
        // }

        // Return
        // Sale del método actual
        for (int i = 0; i < 10; i++)
        {
            if (i == 3)
            {
                return;
            }
            WriteLine(i);
        }




    }
}