using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class TodosList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(Todo))]
        public List<int> TodoId { get; set; }
    }
}
