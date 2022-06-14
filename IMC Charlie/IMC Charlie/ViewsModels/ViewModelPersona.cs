using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using IMC_Charlie.Models;
using Xamarin.Forms;

namespace IMC_Charlie.ViewsModels
{
    public class ViewModelPersona : INotifyPropertyChanged
    {

        public ViewModelPersona()
        {



            Guardar = new Command(() => {
               
                PER.CalcularIMC();
                PER = PER;


                BinaryFormatter formatter = new BinaryFormatter();
                string ruta = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Persona.aut");
                Stream archivo = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(archivo, PER);
                archivo.Close();

            });

            Abrir = new Command(() => {


                BinaryFormatter formatter = new BinaryFormatter();
                string ruta = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "Persona.aut");
                Stream archivo = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.None);
                PER = (Persona)formatter.Deserialize(archivo);

                archivo.Close();

            });


        }



        String nombre;

        public String Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                var args = new PropertyChangedEventArgs(nameof(Nombre));
                PropertyChanged?.Invoke(this, args);
            }
        }

        String fecha_nacimiento;

        public String Fecha
        {
            get => fecha_nacimiento;
            set
            {

                fecha_nacimiento = value;
                var args = new PropertyChangedEventArgs(nameof(Fecha));
                PropertyChanged?.Invoke(this, args);

            }
        }

        string genero;
        public String Genero
        {
            get => genero;
            set
            {

                genero = value;
                var args = new PropertyChangedEventArgs(nameof(Genero));
                PropertyChanged?.Invoke(this, args);

            }
        }

        double peso = 0;
        public double Peso
        {

            get => peso;
            set
            {

                peso = value;
                var args = new PropertyChangedEventArgs(nameof(Peso));
                PropertyChanged?.Invoke(this, args);

            }

        }

        double estatura = 0;


        public double Estatura
        {

            get => estatura;
            set
            {

                estatura = value;
                var args = new PropertyChangedEventArgs(nameof(Estatura));
                PropertyChanged?.Invoke(this, args);

            }

        }

       



        Persona person = new Persona();
        public Persona PER
        {
            get => person;
            set
            {

                person = value;
                var args = new PropertyChangedEventArgs(nameof(PER));
                PropertyChanged?.Invoke(this, args);

                
                    
                
            }
        }

        public Command Guardar { get; }

        public Command Abrir { get; }

       

        public event PropertyChangedEventHandler PropertyChanged;


}
    }

