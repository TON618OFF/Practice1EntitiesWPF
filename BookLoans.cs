//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practice_1_entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookLoans
    {
        public int ID_Loan { get; set; }
        public Nullable<int> Book_ID { get; set; }
        public Nullable<int> Reader_ID { get; set; }
        public string LoanDate { get; set; }
        public string ReturnDate { get; set; }
    
        public virtual Books Books { private get; set; }
        public virtual Readers Readers { private get; set; }
    }
}
