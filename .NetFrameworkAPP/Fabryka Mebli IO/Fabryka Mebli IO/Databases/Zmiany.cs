//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fabryka_Mebli_IO.Databases
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zmiany
    {
        public int idZmiany { get; set; }
        public int idKierownika { get; set; }
    
        public virtual Pracownicy Pracownicy { get; set; }
    }
}
