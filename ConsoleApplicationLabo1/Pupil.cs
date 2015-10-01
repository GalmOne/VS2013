using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Pupil : Person
    {
        public int Grade { get; set; }

        
        public List<Activity> lstActivities;

        internal List<Activity> LstActivities
        {
            get { return lstActivities; }
            set { lstActivities = value; }
        }
        public char[] tabEval;

        public char[] TabEval
        {
            get { return tabEval; }
            set { tabEval = value; }
        }

        public Pupil(String name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[10];
        }

        public Pupil(String name, int age) : this(name, age, 1)
        {

        }

        public void AddActivity (Activity acti)
        {
            LstActivities.Add(acti); 
        }

        public void addEvaluation(String Title = null, char Evaluation = (char) Parameter.Evaluation.Satisfaisant)
        {
            int i = 0;
            if(Title != null)
            {
                foreach(Activity activity in LstActivities)
                {
                    if (activity.Title.Equals(Title)) break;
                    i++;
                }
                TabEval[i] = Evaluation;
            }
        }

        public override string ToString()
        {
            string ch = base.ToString() + ((LstActivities.Count() != 0) ? " a choisi : \n" : " n'a pas encore choisi d'activité!\n");

            int i;
            for (i = 0; i < LstActivities.Count(); i++)
                ch += LstActivities[i] + "\n";

            return ch;
        }
    }
}
