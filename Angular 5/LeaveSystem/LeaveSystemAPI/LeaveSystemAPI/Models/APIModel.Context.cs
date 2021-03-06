﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeaveSystemAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class APIModelEntities : DbContext
    {
        public APIModelEntities()
            : base("name=APIModelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Leave_Requests> Leave_Requests { get; set; }
        public virtual DbSet<Leaf> Leaves { get; set; }
        public virtual DbSet<GetAllLeaf> GetAllLeaves { get; set; }
    
        public virtual ObjectResult<GetLeavesForAMonth_Result> GetLeavesForAMonth(Nullable<int> month)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetLeavesForAMonth_Result>("GetLeavesForAMonth", monthParameter);
        }
    
        public virtual ObjectResult<GetLeavesForAnEmployee_Result> GetLeavesForAnEmployee(Nullable<int> eMP_ID)
        {
            var eMP_IDParameter = eMP_ID.HasValue ?
                new ObjectParameter("EMP_ID", eMP_ID) :
                new ObjectParameter("EMP_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetLeavesForAnEmployee_Result>("GetLeavesForAnEmployee", eMP_IDParameter);
        }
    }
}
