using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databaseStudensStady2.Models
{
    [Table("Students")]
    public class Student

    {
        [Column("id")]
        public int Id {get; set; }
        [Column("name")]
        public string Name {get; set; }
        [Column("group")]
        public string Group {get; set; }
        
    }
}
