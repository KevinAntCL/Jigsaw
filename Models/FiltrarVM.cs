using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaJigsaw.Data;

namespace PracticaJigsaw.Models
{
    public class FiltrarVM
    {
        //  Buscamos realizar dos listas de selccion para hacer busquedas por temas y tamanos
        public List<Rompecabezas> Jigs { get; set; }
        public SelectList ListaTema { get; set; }
        public SelectList ListaSize { get; set; }

        //  Cadena de busqueda
        public string BuscarTema { get; set; }
        public string BuscarSize { get; set; }
    }
}
