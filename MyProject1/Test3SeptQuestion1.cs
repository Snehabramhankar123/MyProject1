using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Application
    {
        string version;
        string technologyused ;
        public Application(string version , string technologyused)
        {
            this.version = version;
            this.technologyused = technologyused;
        }
        public string Version
        { set { version = value; }
            get { return version; }

        }

    }
    class Developer
    {
        string devName;
        int devExperience;
        string skills;
        public Developer(string devName , int devExperience,string skills)
        {
            this.devName = devName;
            this.devExperience = devExperience;
            this.skills = skills;
        }
        public string DevName
        {
            set { devName = value; }
            get { return devName; }
        }
        public int  DevExperience
        {
            set { devExperience = value; }
            get { return devExperience; }
        }
        public string Skills
        {
            set { skills = value; }
            get { return skills; }

        }
            



    }
    class DesktopApplication
    {

    }
    class WebApplication
    {

    }
    class MobileApplication
    {

    }
}
