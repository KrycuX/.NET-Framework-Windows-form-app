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
    
    public partial class DaneZamawiajacego
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DaneZamawiajacego()
        {
            this.Zamówienie = new HashSet<Zamówienie>();
        }
    
        public int id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Nullable<int> NrTel { get; set; }
        public string Miasto { get; set; }
        public string Ulica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamówienie> Zamówienie { get; set; }
    }
}