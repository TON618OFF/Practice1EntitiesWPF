﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BookSystemEntities : DbContext
    {
        public BookSystemEntities()
            : base("name=BookSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<BookLoans> BookLoans { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Readers> Readers { get; set; }
    }
}