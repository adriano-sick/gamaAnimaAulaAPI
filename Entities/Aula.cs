using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Aula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        public string Subject { get; set; }
        public string Teacher { get; set; }
        public string Duration { get; set; }
        public string Link { get; set; }
    }
}


