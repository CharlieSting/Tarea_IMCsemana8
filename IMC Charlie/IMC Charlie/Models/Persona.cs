using System;
using System.Collections.Generic;
using System.Text;

namespace IMC_Charlie.Models
{
    [Serializable]
    public class Persona
    {
        public string nombre { get; set; }
        public string fecha_nacimiento { get; set; }
        public double peso { get; set; }
        public double estatura { get; set; }

        public double IMC { get; set; } = 0;

        public string genero { get; set; }


        public void CalcularIMC()
        {
            CalcularIMC();
            IMC = peso / (Math.Pow(estatura, 2));

            
        }



    }
}
    

