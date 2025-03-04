﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class OperationClaim:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<UserOperationClaim> UserOperationClaim { get; set; }
        public OperationClaim()
        {
            UserOperationClaim = new HashSet<UserOperationClaim>();
        }
    }
}
