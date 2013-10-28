using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GestorSuministro.BLL.Referencias
{
    public class CProveedor
    {
        #region Properties
        [Display(Name = "Id Proveedor")]
        public int IdProveedor { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Display(Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }  
        [Display(Name = "Celular")]
        [DataType(DataType.PhoneNumber)]
        public string Celular { get; set; }
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Display(Name = "Estado")]
        public bool? Estado { get; set; }
        [Display(Name = "Garantia")]
        public string Garantia { get; set; }
        [Display(Name = "Tiempo Entrega")]
        public string TiempoEntrega { get; set; }
        [Display(Name = "Usuario")]
        public string Usuario { get; set; }
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }
        #endregion
    }
}
