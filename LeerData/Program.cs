using Internal;
using System;
using Microsoft.EntityFrameworkCore;

namespace LeerData
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using(var db = new AppVentaCursosContext()) 
            {
                // AsNoTracking no guarde en cache
                var cursos = db.Curso.Include( p => p.Precio ).AsNoTracking(); // arreglo IQueryable

                foreach (var curso in cursos)
                {
                    // Console.WriteLine(curso.Titulo + " - " + curso.Precio.PrecioActual);
                    Console.WriteLine(curso.Titulo + " - " + curso.Precio.PrecioActual);
                }
            }

        }
    }
}
