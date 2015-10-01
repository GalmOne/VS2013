﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class PersonComparer : IEqualityComparer<Person>
    {

        public Boolean Equals (Person p1, Person p2)
        {

            if (p1 == p2 || (p1.Name.Equals(p2.Name) && p1.Age.Equals(p2.Age)))
                return true;
            else
                return false;            
        }

        public int GetHashCode (Person p)
        {
            return p.Name.GetHashCode() ^ p.Age;
        }
    }
}
