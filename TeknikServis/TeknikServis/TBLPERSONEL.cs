//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLPERSONEL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLPERSONEL()
        {
            this.TBLFATURABILGI = new HashSet<TBLFATURABILGI>();
            this.TBLURUNHAREKET = new HashSet<TBLURUNHAREKET>();
            this.TBLURUNKABUL = new HashSet<TBLURUNKABUL>();
        }
    
        public short ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public Nullable<byte> DEPARTMAN { get; set; }
        public string FOTOĞRAF { get; set; }
        public string MAIL { get; set; }
        public string TELEFON { get; set; }
    
        public virtual TBLDEPARTMAN TBLDEPARTMAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLFATURABILGI> TBLFATURABILGI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURUNHAREKET> TBLURUNHAREKET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURUNKABUL> TBLURUNKABUL { get; set; }
    }
}
