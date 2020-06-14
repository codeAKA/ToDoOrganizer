using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public User Author { get; set; }
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
        public string Title { get; set; }
        [StringLength(2000, ErrorMessage = "Content cannot be longer than 2000 characters")]
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DueDate { get; set; }
        public List<string> Priorities { get; set; }
        public List<string> Status { get; set; }

    }
}
