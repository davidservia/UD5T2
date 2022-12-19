using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using UD5T2.models;

namespace UD5T2.ViewModels
{
    //Clase BMIViewModel
    public class BMIViewModel
    {
        public BMI BMI { get; set; }

        //Constructor
        public BMIViewModel()
        {
            BMI = new BMI();
            BMI.Peso = 50;
            BMI.Altura = 25;
        }
    }
}