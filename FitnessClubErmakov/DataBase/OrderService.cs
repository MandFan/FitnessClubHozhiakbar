//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessClubErmakov.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderService
    {
        public int IdOrder { get; set; }
        public int IdService { get; set; }
        public int Quantity { get; set; }
        public decimal Summary { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Service Service { get; set; }
    }
}