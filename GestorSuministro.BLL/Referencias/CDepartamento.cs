using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GestorSuministro.BLL.Referencias
{
    public class CDepartamento
    {
        #region Propiedades
        [Display(Name = "Id Departamento")]
        public int IdDepartamento { get; set; }
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Display(Name = "Abreviación")]
        public string Abrev { get; set; }
        [Display(Name = "Estado")]
        public bool Estado { get; set; }
        [Display(Name = "Usuario")]
        public string Usuario { get; set; }
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }
        #endregion

    }
}
