using System;

namespace Happy_tickets
{
    class Program
    {
        //Why array reasignment is wrong? arrBase = sumVariants
        static void Main(string[] args)
        {
            int numberDigits = int.Parse(Console.ReadLine());
            int arrValue = (9 * numberDigits) + 1;
            int[] arrBase = new int[(9 * (numberDigits-1)) + 1];
            for (int i = 0; i < 10; i++)
                arrBase[i] = 1;
            int[] sumVariants = new int[arrValue];
            int resultSumSquareSumVariants = 0;

            if (numberDigits == 1)
                resultSumSquareSumVariants = 10;
            else
            {
                for (int indexNumberDigits = 2; indexNumberDigits <= numberDigits; indexNumberDigits++)
                {
                    for (int indexSumVariants = 0; indexSumVariants < 10; indexSumVariants++)
                    {
                        for (int indexArrBase = 0; indexArrBase < 10; indexArrBase++)
                        {
                            sumVariants[indexArrBase + indexSumVariants] += arrBase[indexArrBase];
                        }
                        if (indexSumVariants == 9)
                            //arrBase = sumVariants;
                            for (int i = 0; i < (9 * (numberDigits - 1)) + 1; i++)
                                arrBase[i] = sumVariants[i] * 1;
                    }
                }
                for (int indexSumVariants = 0; indexSumVariants < arrValue; indexSumVariants++)
                    resultSumSquareSumVariants += sumVariants[indexSumVariants] * sumVariants[indexSumVariants];

                Console.WriteLine(resultSumSquareSumVariants);

            }

        }
    }
}
