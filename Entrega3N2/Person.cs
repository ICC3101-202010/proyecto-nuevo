﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega3N2
{

    [Serializable]
    public class Person
    {
        protected string Name;
        protected List<string> Professions;


        public Person(string name)
        {
            Name = name;
            List<string> professions = new List<string>();
            Professions = professions;

        }

        public string GetName()
        {
            return Name;
        }

        public List<string> GetProfessions()
        {
            return Professions;
        }

        public void AddProfession(string prof)
        {
            if (Professions.Contains(prof))
            {
                return;
            }
            else
            {
                Professions.Add(prof);
            }


        }
    }
}
