using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndividualGradebook
{
    public class Indstudent
    {
       
        string _studentname;

        public string Studentname
        {
            get { return _studentname; }
            set { _studentname = value; }
        }
        string _Studentrollno;

        public string Studentrollno
        {
            get { return _Studentrollno; }
            set { _Studentrollno = value; }
        }
        int _tamil;
        int _english;
        int _maths;
        int _science;
        int _social;

       
        public Indstudent()
        {
            this.Studentname = "xxx";
            this.Studentrollno = "xxx";
            this.Tamil = 0;
            this.English = 0;
            this.Maths = 0;
            this.Science = 0;
            this.Social = 0;

        }
        public int Tamil
        {
            get { return _tamil; }
            set { _tamil = value; }
        }
       
        public int English
        {
            get { return _english; }
            set { _english = value; }
        }
        public int Maths
        {
            get { return _maths; }
            set { _maths = value; }
        }
        public int Science
        {
            get { return _science; }
            set { _science = value; }
        }
        public int Social
        {
            get { return _social; }
            set { _social = value; }
        }

       
    }
}
