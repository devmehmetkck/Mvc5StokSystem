//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketAsp.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblUrunler
    {
        public int UrunBarkod { get; set; }
        public Nullable<double> UrunFiyat { get; set; }
        public string UrunIsim { get; set; }
    
        public virtual TblStok TblStok { get; set; }
    }
}