using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FewMoreConcepts1
{
    public class GuidedProjectData
    {
        //int sophiaSum = 0;
        //int nicolasSum = 0;
        //int zahirahSum = 0;
        //int jeongSum = 0;

  

        //int sophia1 = 93;
        //int sophia2 = 87;
        //int sophia3 = 98;
        //int sophia4 = 95;
        //int sophia5 = 100;




        //int nicolas1 = 80;
        //int nicolas2 = 83;
        //int nicolas3 = 82;
        //int nicolas4 = 88;
        //int nicolas5 = 85;

        

        //int zahirah1 = 84;
        //int zahirah2 = 96;
        //int zahirah3 = 73;
        //int zahirah4 = 85;
        //int zahirah5 = 79;

       

        //int jeong1 = 90;
        //int jeong2 = 92;
        //int jeong3 = 98;
        //int jeong4 = 100;
        //int jeong5 = 97;

        
        


        public void SumOfSubjects()

        {

            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int[] sophiaScore = new[] { 93, 87, 98, 95, 100 };
            int[] nicolasScore = new[] { 80, 83, 82, 88, 85 };
            int[] zahirahScore = new[] { 84, 96, 73, 85, 79 };
            int[] jeongScore = new[] { 90, 92, 98, 100, 97 };

            int sophiaSum = 0;
            int nicolasSum = 0;
            int zahirahSum = 0;
            int jeongSum = 0;

            decimal sophiaScoreDecimal;
            decimal nicolasScoreDecimal;
            decimal zahirahScoreDecimal;
            decimal jeongScoreDecimal;



            foreach (int score in sophiaScore)
            {
                sophiaSum += score;
            }

            foreach(int score in nicolasScore)
            {
                nicolasSum += score;
            }
            foreach(int score in zahirahScore)
            {
                zahirahSum += score;
            }

            foreach(int score in jeongScore)
            {
                jeongSum += score;
            }

            //int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            //int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            //int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            //int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            Console.WriteLine("SophiSum : " +  sophiaSum);
            Console.WriteLine("NicolasSum : " + nicolasSum);
            Console.WriteLine("ZahirahSum : " + zahirahSum);
            Console.WriteLine("JeongSum : " + jeongSum);

            Console.WriteLine("SophiaScore : " + sophiaScore);
            Console.WriteLine("NicolasScore: " + nicolasScore);
            Console.WriteLine("zahirahScore: " + zahirahScore);
            Console.WriteLine("jeongScore: " + jeongScore);

            sophiaScoreDecimal = (decimal)sophiaSum / currentAssignments;
            nicolasScoreDecimal = (decimal)nicolasSum / currentAssignments;
            zahirahScoreDecimal = (decimal)zahirahSum / currentAssignments;
            jeongScoreDecimal = (decimal)jeongSum / currentAssignments;

            Console.WriteLine("SophiaScore : " + sophiaScoreDecimal);
            Console.WriteLine("NicolasScore: " + nicolasScoreDecimal);
            Console.WriteLine("zahirahScore: " + zahirahScoreDecimal);
            Console.WriteLine("jeongScore: " + jeongScoreDecimal + "\n");

            Console.WriteLine("Student\tGrade\n");
            Console.WriteLine("Sophia:\t" + sophiaScoreDecimal + "\tA");
            Console.WriteLine("Nicolas:\t" + nicolasScoreDecimal + "\tB");
            Console.WriteLine("JeongScore : " + jeongScoreDecimal + "\tA");
            Console.WriteLine("Zahirah : " + jeongScoreDecimal + "\tB");

            var value = (int)20 / (int)2;
            Console.WriteLine(value);
        }
    }
}
