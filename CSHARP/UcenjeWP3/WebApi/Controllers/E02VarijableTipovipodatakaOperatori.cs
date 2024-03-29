﻿

using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController ]
    [Route ("E02")]
    public class E02VarijableTipovipodatakaOperatori: ControllerBase
    {



        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad1")]
        public int Zad1()
        {
            // Ruta vraća najveći int broj
            return int.MaxValue;
        }
        // Ovdje završava ruta



        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad2")]
        public int Zad2(int a, int b)
        {
            // ruta vrača kvocjent dvaju primljenih brojeva
            return int.MaxValue;

        }
        // Ovdje završava ruta



        // Ruta prima dva cijela broja i vraća zbroj umnoška i kvocijenta primljenih brojeva
        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad3")]
        public float Zad3(int a, int b)
        {
        
            return (a+b) + (a/(float)b);

        }
        // Ovdje završava ruta


     

        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad4")]
        public bool Zad4(int a, int b)
        {
            // Ruta prima dva cijela broja, vraća true ako je a jednako b, inače vraća false
            return a == b;

        }
        // Ovdje završava ruta


        // Ovdje počinje ruta
        [HttpGet]
        [Route("zad5")]
        public string Zad5(int a, int b)
        {
            // Ruta prima dva stringa i vraća ih sljepljene s razmakom nazad

            return a + " " + b;

        }
        // Ovdje završava ruta




    }





}

