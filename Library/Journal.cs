//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class Journal
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int ManagerId { get; set; }
        public int ReaderId { get; set; }
        public System.DateTime IssueDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Managers Managers { get; set; }
        public virtual Readers Readers { get; set; }
    }
}
