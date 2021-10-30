using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practica2E1ResitenciasEstrella.Domain;

/*
Universidad Tecnologica Metropolitana
Materia: Aplicaciones Web Orientadas a Servicios
Maestro: Joel Ivan Chuc Uc 
Practica 3: Resistencias
Alumno: Jesus Ivan Estrella Yah
4to Cuatrimestre 4B
2do Parcial
Fecha: 30 - Octubre - 2021
*/

namespace Practica2E1ResitenciasEstrella.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValoresController : ControllerBase
    {
        [HttpGet]
        [Route("Calcular_Resistencias")]
        public IActionResult Operaciones(string PraBanda, string SdaBanda, string TraBanda, string CtaBanda)
        {
            InColores colorines = new InColores();
            colorines.Color = PraBanda.ToUpper();
            var Texto = "";

            switch (colorines.Color)
            {
                case "NEGRO":
                    colorines.Valor = 0;
                    break;

                case "CAFE":
                    colorines.Valor = 1;
                    break;

                case "ROJO":
                    colorines.Valor = 2;
                    break;

                case "NARANJA":
                    colorines.Valor = 3;
                    break;

                case "AMARILLO":
                    colorines.Valor = 4;
                    break;

                case "VERDE":
                    colorines.Valor = 5;
                    break;

                case "AZUL":
                    colorines.Valor = 6;
                    break;

                case "VIOLETA":
                    colorines.Valor = 7;
                    break;

                case "GRIS":
                    colorines.Valor = 8;
                    break;

                case "BLANCO":
                    colorines.Valor = 9;
                    break;

                default:
                    Texto = "El color de banda 1 ingresado es inválido, prueba con los siguientes: Negro, Cafe, Rojo, " +
                        "Naranja, Amarillo, Verde, Azul, Violeta, Gris o Blanco";
                    return Ok(Texto);
            }
            var PrimeraBanda = colorines.Valor;


            colorines.Color = SdaBanda.ToUpper();
            switch (colorines.Color)
            {
                case "NEGRO":
                    colorines.Valor = 0;
                    break;

                case "CAFE":
                    colorines.Valor = 1;
                    break;

                case "ROJO":
                    colorines.Valor = 2;
                    break;

                case "NARANJA":
                    colorines.Valor = 3;
                    break;

                case "AMARILLO":
                    colorines.Valor = 4;
                    break;

                case "VERDE":
                    colorines.Valor = 5;
                    break;

                case "AZUL":
                    colorines.Valor = 6;
                    break;

                case "VIOLETA":
                    colorines.Valor = 7;
                    break;

                case "GRIS":
                    colorines.Valor = 8;
                    break;

                case "BLANCO":
                    colorines.Valor = 9;
                    break;

                default:
                    Texto = "El color de la banda 2 ingresado es inválido, prueba con los siguientes: Negro, Cafe, Rojo, " +
                        "Naranja, Amarillo, Verde, Azul, Violeta, Gris o Blanco";
                    return Ok(Texto);
            }
            var SegundaBanda = colorines.Valor;


            colorines.Color = TraBanda.ToUpper();
            switch (colorines.Color)
            {

                case "NEGRO":
                    colorines.MultiYDivi = 1;
                    break;

                case "CAFE":
                    colorines.MultiYDivi = 10;
                    break;

                case "ROJO":
                    colorines.MultiYDivi = 100;
                    break;

                case "NARANJA":
                    colorines.MultiYDivi = 1000;
                    break;

                case "AMARILLO":
                    colorines.MultiYDivi = 10000;
                    break;

                case "VERDE":
                    colorines.MultiYDivi = 100000;
                    break;

                case "AZUL":
                    colorines.MultiYDivi = 1000000;
                    break;

                case "DORADO":
                    colorines.MultiYDivi = 10;
                    break;

                case "PLATEADO":
                    colorines.MultiYDivi = 100;
                    break;

                default:
                    Texto = "El color de la banda 3 ingresado es inválido, prueba con los siguientes: Negro, Cafe, Rojo, " +
                        "Naranja, Amarillo, Verde, Azul, Dorado o Plateado";
                    return Ok(Texto);

            }
            var TerceraBanda = colorines.MultiYDivi;


            colorines.Color = CtaBanda.ToUpper();
            switch (colorines.Color)
            {

                case "PLATEADO":
                    colorines.Valor = 10;
                    break;

                case "DORADO":
                    colorines.Valor = 5;
                    break;

                default:
                    Texto = "El color de la banda 4 ingresado es inválido, prueba con los siguientes: Dorado o Plateado";
                    return Ok(Texto);

            }
            var CuartaBanda = colorines.Valor;


            float Resultado;
            var Concatenado  = Int32.Parse($"{PrimeraBanda}{SegundaBanda}");

            if (TraBanda.ToUpper() == "DORADO" || TraBanda.ToUpper() == "PLATEADO")
            {
                Resultado = (Concatenado / TerceraBanda);
            }
            else
            {
                Resultado = (Concatenado * TerceraBanda);
            }

            Texto = $"El valor es de la resistencia es de: {Resultado} Ω y su tolerancia es de {CuartaBanda} %";
            return Ok(Texto);

        }
    }
}
