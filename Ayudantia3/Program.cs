using System;
using System.Collections.Generic;
using Ayudantia3.Models;

using Ayudantia3.Controllers;

namespace Ayudantia3
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometriaController geometria = new GeometriaController();
            SocialTechController socialTech = new SocialTechController();

            geometria.Ejecutar();
            socialTech.Ejecutar();
        }
    }
}