using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica2APiEjercicio1.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2APiEjercicio1.Controllers
{

    /*
      
        Nombre de la escuela: Universidad Tecnologica Metropolitana

        Materia: Aplicaciones Web Orientadas a Servicios

        Profesor: Joel Chuc

        Actividad: (Resistencia)

        Alumno: Hernandez Carrillo Cristian Santiago
    
        Cuatrimestre: 4

        Grupo: B

        Parcial: 2
     
     
     */


    [Route("api/[controller]")]
    [ApiController]
    public class ResistenciaController : ControllerBase
    {
        [HttpGet]
        [Route("Resistencia")]
        public IActionResult Resistencia(string colores1, string colores2, string colores3, string colores4)
        {

            objResistencia color = new objResistencia();

            ColorDiferente diferente = new ColorDiferente();

            var dato = "";


            color.NombreColor = colores1.ToLower() ;


            switch (color.NombreColor)
            {

                case "negro":

                    color.banda = 0;

                    break;

                case "cafe":

                    color.banda = 1;

                    break;

                case "rojo":

                    color.banda = 2;

                    break;

                case "naranja":

                    color.banda = 3;

                    break;

                case "amarillo":

                    color.banda = 4;

                    break;

                case "verde":

                    color.banda = 5;

                    break;

                case "azul":

                    color.banda = 6;

                    break;

                case "violeta":

                    color.banda = 7;

                    break;

                case "gris":

                    color.banda = 8;

                    break;

                case "blanco":

                    color.banda = 9;

                    break;

                default:

                    dato = $"Color '{color.NombreColor}'inválido";

                    return Ok(dato);

            }


            var dato1 = color.banda;
            color.NombreColor = colores2.ToLower();

            switch (color.NombreColor)
            {

                case "negro":

                    color.banda = 0;

                    break;

                case "cafe":

                    color.banda = 1;

                    break;

                case "rojo":

                    color.banda = 2;

                    break;

                case "naranja":

                    color.banda = 3;

                    break;

                case "amarillo":

                    color.banda = 4;

                    break;

                case "verde":

                    color.banda = 5;

                    break;

                case "azul":

                    color.banda = 6;

                    break;

                case "violeta":

                    color.banda = 7;

                    break;

                case "gris":

                    color.banda = 8;

                    break;

                case "blanco":

                    color.banda = 9;

                    break;

                default:

                    dato = $"El segundo color '{color.NombreColor}' es inválido, usa colores existentes para una resistencia";

                    return Ok(dato);

            }
            var dato2 = color.banda;
            color.NombreColor = colores3.ToLower();

            switch (color.NombreColor)
            {

                case "negro":

                    color.multiplicidad = 1;

                    break;

                case "cafe":

                    color.multiplicidad = 10;

                    break;

                case "rojo":

                    color.multiplicidad = 100;

                    break;

                case "naranja":

                    color.multiplicidad = 1000;

                    break;

                case "amarillo":

                    color.multiplicidad = 10000;

                    break;

                case "verde":

                    color.multiplicidad = 100000;

                    break;

                case "azul":

                    color.multiplicidad = 1000000;

                    break;

               
                case "dorado":

                    color.multiplicidad = 10;

                    break;

                case "plata":

                    color.multiplicidad = 100;

                    break;

                default:

                    dato = $"Color '{color.NombreColor}' inválido";

                    return Ok(dato);

            }

            var dato3 = color.multiplicidad;
            color.NombreColor = colores4.ToLower();
            switch (color.NombreColor)
            {
                case "plata":

                    color.multiplicidad = 10;

                    break;


                case "dorado":

                    color.multiplicidad = 5;

                    break;

                default:
                    dato = $"Color'{color.NombreColor}' inválido";
                    break;


            }

            var dato4 = color.multiplicidad;
            float resultado = 0;
            var diferencia = Int32.Parse($"{dato1}{dato2}");
            if (colores3.ToLower() == "dorado" || colores3.ToLower() == "plata")
            {
                resultado = diferencia / dato3;
            }
            else
            {
                resultado = (diferencia * dato3);
            }

            dato = $"El valor es {resultado} omh y su tolerancia es de {dato4}%";

            return Ok(dato);
              
            
           
              






           
        }

    }
}
