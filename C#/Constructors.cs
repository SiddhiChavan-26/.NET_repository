using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNET_Practice
{
    internal class Constructors
    {
        public string model;
        public string color;
        public int year;

        public Constructors(string modelName, string colorOfcar,int yearCreated)
        {
            model = modelName;
            color = colorOfcar;
            year = yearCreated;
        }

    }
}
