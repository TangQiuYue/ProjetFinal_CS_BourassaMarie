using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_CS_BourassaMarie
{
    class Course
    {
        private string codeCours;
        private string nomCourse;
        private int HeuresCours;

        public Course(string codeCours, string nomCourse, int heuresCours)
        {
            this.codeCours = codeCours;
            this.nomCourse = nomCourse;
            HeuresCours = heuresCours;
        }
        public Course() { }

        public string CodeCours
        {
            get
            {
                return codeCours;
            }

            set
            {
                codeCours = value;
            }
        }

        public string NomCourse
        {
            get
            {
                return nomCourse;
            }

            set
            {
                nomCourse = value;
            }
        }

        public int HeuresCours1
        {
            get
            {
                return HeuresCours;
            }

            set
            {
                HeuresCours = value;
            }
        }
    }
}
