using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace UD5T2.models
{
    [AddINotifyPropertyChangedInterface]

    //Modelo BMi
    public class BMI
    {

        private float resultado;
        private string resultadoBMI;

        public float Altura { get; set; }
        public float Peso { get; set; }

        //propiedad publica
        public float Resultado
        {
            get
            {
                resultado = (10000 * Peso / (float)(Math.Pow(Altura, 2)));
                return resultado;
            }
        }
        //propiedad publica tipo string
        public string ResultadoBMI
        {
            get
            {
                string mensaje = "";
                if (Resultado <= 16)
                {
                    mensaje = "BMI: Delgado Severo";
                }
                else if (Resultado > 16 && Resultado <= 17)
                {
                    mensaje = "BMI: Delgado Moderado";
                }
                else if (Resultado > 17 && Resultado <= 18.5)
                {
                    mensaje = "BMI: Delgado Medio";
                }
                else if (Resultado > 18.5 && Resultado <= 25)
                {
                    mensaje = "BMI: Normal";
                }
                else if (Resultado > 25 && Resultado <= 30)
                {
                    mensaje = "BMI: Sobrepeso";
                }
                else if (Resultado > 30 && Resultado <= 35)
                {
                    mensaje = "BMI: Obesidad Clase I";
                }
                else if (Resultado > 35 && Resultado <= 40)
                {
                    mensaje = "BMI: Obesidad Clase II";
                }
                else
                {
                    mensaje = "BMI: Obesidad Clase III";
                }

                return mensaje;

            }

            set
            {
                resultadoBMI = value;
            }
        }
    }
}