using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinal_CS_BourassaMarie
{
    class ProgramsClass
    {
        private string codePrograms;
        private string nameProgram;
        private string course1;
        private string course2;
        private string course3;
        private string course4;
        private string course5;

        public ProgramsClass()
        {

        }

        public ProgramsClass(string codePrograms, string nameProgram, string course1, string course2, string course3, string course4, string course5)
        {
            this.codePrograms = codePrograms;
            this.nameProgram = nameProgram;
            this.course1 = course1;
            this.course2 = course2;
            this.course3 = course3;
            this.course4 = course4;
            this.course5 = course5;
        }

        public string CodePrograms
        {
            get
            {
                return codePrograms;
            }

            set
            {
                codePrograms = value;
            }
        }

        public string NameProgram
        {
            get
            {
                return nameProgram;
            }

            set
            {
                nameProgram = value;
            }
        }

        public string Course1
        {
            get
            {
                return course1;
            }

            set
            {
                course1 = value;
            }
        }

        public string Course2
        {
            get
            {
                return course2;
            }

            set
            {
                course2 = value;
            }
        }

        public string Course3
        {
            get
            {
                return course3;
            }

            set
            {
                course3 = value;
            }
        }

        public string Course4
        {
            get
            {
                return course4;
            }

            set
            {
                course4 = value;
            }
        }

        public string Course5
        {
            get
            {
                return course5;
            }

            set
            {
                course5 = value;
            }
        }
    }
}
