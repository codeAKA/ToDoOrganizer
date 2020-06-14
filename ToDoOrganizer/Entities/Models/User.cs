using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [ForeignKey(nameof(Todo))]
        public List<int> TodoId { get; set; }
        [ForeignKey(nameof(TodosList))]
        public List<int> TodosListId { get; set; }
    }
}
