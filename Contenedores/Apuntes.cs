using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// validar componedntes con IDataErrorInfo
using System.ComponentModel;
// Expresiones Regulares
using System.Text.RegularExpressions;
namespace Contenedores
{

    public class Apuntes : IDataErrorInfo
    {
        // Variables privadas de la clase
        private string ciclo="";
        private string modulo="";
        private string curso= "";
        private string titulo="";
        private string fecha = "";
        private string enlace= "";
        private string email="";
        private string descripcion="";

        private string[] listaCiclos = new string[] { "DAM", "DAW", "SMR" };
        // Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

       
        // Campos miembro de la clase
        public string Ciclo
        {
            get { return ciclo; }
            set { ciclo = value; }
        }
        public string Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        //Email Validar utilizando expresiones regulares
        //   Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        //  return regex.IsMatch(s);

        public string Error
        {
            get
            {
                return null;
            }
        }




        // Metodo que es oblligatorio de implementar al extender la clase claseIDataErrorInfo
        public string this[string name]
        {

            get
            {
                string result = null;

                // Validar Ciclo
                if (name == "Ciclo")
                {
                    Boolean correcto = false;
                    foreach (string cicloRegistro in listaCiclos)
                    {
                        if (this.ciclo == cicloRegistro)
                        {
                            correcto = true;
                            break;
                        }

                    }
                    if (correcto == false)
                    {
                        result = "Ciclos Incorrecto(DAM, DAW, SMR.";
                    }
                }


                // Validar Curso formato correcto año-año

                if (name == "Curso")
                {
                  Regex regex = new Regex(@"\d{4}(-\d{4})$");
                  //  Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                    if (!regex.IsMatch(this.curso))
                    {
                        result = "Curso Incorrecto(yyyy-yyyy)";
                    }
                }

                


                // Validar Fecha 
                if (name == "Fecha")
                {
                    Regex regex = new Regex(@"(((0|1|2)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
                    // Regex regex = new Regex(@"(((0|1|2)[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");

                    if (!regex.IsMatch(this.fecha))
                    {
                        result = "Fecha Incorrecta (dd/mm/yyyy)";
                    }
                }

                // Validar Email
                if (name == "Email")
                {
                    Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                

                    if (!regex.IsMatch(this.email))
                    {
                        result = "Email incorrectol";
                    }
                }

                // Validar enlace   
                if (name == "Enlace")
                {
                    Regex regex = new Regex(@"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$");
                     

                    if (!regex.IsMatch(this.enlace))
                    {
                        result = "Enlace incorrectol";
                    }
                }

                return result;
            }
        }
    }
}

