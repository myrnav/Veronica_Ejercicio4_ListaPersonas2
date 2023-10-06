using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veronica_Ejercicio4_ListaPersonas2
{
    /*
     * Ejercicio 04 
Se requiere el ingreso de una lista de personas. Debe ser posible modificar y/o eliminar datos ya ingresados: 
•	Documento (requerido, 7-8 dígitos)
•	Nombre (requerido, max. 30)
•	Apellido (requerido, max. 30)
•	Número de teléfono:
o	Tipo (requerido): CASA/TRABAJO/OTRO
o	Código de Pais (requerido, 2 cifras)
o	Código de Area (requerido, 2 cifras)
o	Numero de teléfono (requerido, 6-8 cifras)
     */

    internal class PersonasModel
    {
        public List<Persona> Personas = new List<Persona>()
        {
             //uso datos harcodeados para armar la pantalla y probar las funcionalidades
	    new Persona {Documento = 33506618, Apellido = "Villagran", Nombre = "Veronica", Telefono = "46561616"},
        new Persona {Documento = 22345666, Apellido = "Martinez", Nombre = "Martin", Telefono = "3344455555"},
        new Persona {Documento = 12334455, Apellido = "Gomez", Nombre = "Dario", Telefono = "11334567890"},
        new Persona {Documento = 33445566, Apellido = "Salvador", Nombre = "Laura", Telefono = "112347777"},
        };

        internal string Borrar(Persona persona)
        {
            if (persona.Documento == 12334455) //harcodeo el valor para saber si tira error
            {
                return "No se puede borrar a esta persona";
            }

            //si no hay problemas, lo borra directamente
            Personas.Remove(persona);
            return null; //sin esto el metodo da error. Aca devuelve una referencia nula, no tiene un objeto
                
        }

        internal string Modificar(Persona personasAModificar, Persona personaNuevaVersion)
        {
            //SE HACEN TODAS LAS VALIDACIONES del modelo
            if (personaNuevaVersion.Documento <0 || personaNuevaVersion.Documento > 99_999_999)
            {
                return "El documento debe ser un número entre 1 y 99.999.999";
            }

            if (string.IsNullOrWhiteSpace(personaNuevaVersion.Apellido))
            {
                return "Debe ingresar un apellido";
            }

            if (personaNuevaVersion.Apellido.Length > 50) 
            {
                return "El apellido debe tener menos de 50 caracteres";
            }

            personasAModificar.Documento = personaNuevaVersion.Documento;
            personasAModificar.Apellido = personaNuevaVersion.Apellido;
            personasAModificar.Nombre = personaNuevaVersion.Nombre;
            personasAModificar.Telefono = personaNuevaVersion.Telefono;

            return null;

        }


        internal string Agregar(Persona personasNueva)
        {
            //SE HACEN TODAS LAS VALIDACIONES del modelo
            

         

            return null;

        }


    }
}
