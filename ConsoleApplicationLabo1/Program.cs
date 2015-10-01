using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity act = new Activity("Math", true);
            Activity act1 = new Activity("C#", false);
            Activity act2 = new Activity("Fr", true);
            Activity act3 = new Activity("Gym", false);
            Activity act4 = new Activity("Cirque", false);
            Activity act5 = new Activity("Video", false);
            

            Pupil pup = new Pupil("Mahatchy", 5, 1);
           



            
            pup.AddActivity(act);
            pup.AddActivity(act1);
            pup.AddActivity(act2);
            pup.AddActivity(act3);
            pup.AddActivity(act4);
            pup.AddActivity(act5);  

            pup.addEvaluation("Math");

            List<Pupil>LstPupils = new List<Pupil>()
            {
                new Pupil("Julie", 8, 1),
                new Pupil("Jules", 7, 1),
                new Pupil("Juliette", 9, 1),
                new Pupil("Julia", 5, 1),
                new Pupil("Julien", 11, 1),
                new Pupil("Juliana", 5, 1),
            };

            
            
            System.Console.Write(pup);
            //System.Console.Read();

            var pupilGrade1Plus6 = from pupil in LstPupils
                                   where pupil.Age > 6
                                   select pupil;

            var pupilsLambda = LstPupils.Where(Pupil => Pupil.Age > 6 && Pupil.Grade == 1);

            if (pupilGrade1Plus6 != null)
            {
                foreach (var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write("\n"+pupil.Name);
                   
                }
            }

            //Covariance

            List<Person> LstPerson = new List<Person>()
            {
                new Person("Arnaud", 22),
                new Person("Florine", 19),
                new Person("Adrien", 16),
            };

            var listFusion = LstPerson.Union(LstPupils);
            System.Console.Write("\n\n ---------Covariance---------");

            foreach (var fusion in listFusion)
            {
                System.Console.Write("\n" + fusion.Name+", "+fusion.Age+" piges");

            }

            List<Pupil> listPupilsDuplicated = new List<Pupil>()
            {
                new Pupil("Arnaud", 22),
                new Pupil("Florine", 19),
                new Pupil("Adrien", 16),
                new Pupil("AnneSo", 19),
                new Pupil("Mahatc", 22),
                new Pupil("Arnaud", 22),
                new Pupil("Florine", 19),
            };
            
            IEnumerable<Pupil> listPupilsNoDuplicated = listPupilsDuplicated.Distinct<Pupil>(new PersonComparer());


            System.Console.Write("\n\n\n"+listPupilsNoDuplicated.Count());

            


            System.Console.Read();
        }
    }
}
