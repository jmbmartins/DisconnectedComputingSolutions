//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleDataApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class LinhaEnc
    {
        public int EncId { get; set; }
        public int ProdutoId { get; set; }
        public Nullable<int> Qtd { get; set; }
    
        public virtual Encomenda Encomenda { get; set; }
    }
}