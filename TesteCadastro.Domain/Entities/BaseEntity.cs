﻿using System.ComponentModel.DataAnnotations;

namespace TesteCadastro.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual int Id { get; set; }
    }
}
