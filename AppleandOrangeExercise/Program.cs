using System;

namespace AppleandOrangeExercise
{
    class Program
    {
        public static void Logic(int leftSideofhouse, int rightSideofHouse, int larryPositioninAppleTree, int robPositioninOrangeTree, int[] applesThrown, int[] orangesThrown){
            int larryScore = 0;
            int robScore = 0;

            foreach(var apple in applesThrown){
                int position = larryPositioninAppleTree + (apple);

                if((position >= leftSideofhouse) && (position <= rightSideofHouse)){
                    larryScore++;
                }
            }

            foreach (var orange in orangesThrown)
            {
                int position = robPositioninOrangeTree + (orange);

                if ((position >= leftSideofhouse) && (position <= rightSideofHouse))
                {
                    robScore++;
                }
            }

            Console.WriteLine(larryScore);
            Console.WriteLine(robScore);
        }

        static void Main(string[] args)
        {
            int[] applesThrown = new int[] { -2, 2, 1 };
            int[] orangesThrown = new int[] { 5,-6 };

            Logic(7, 11, 5, 15, applesThrown, orangesThrown);

        }
    }
}
