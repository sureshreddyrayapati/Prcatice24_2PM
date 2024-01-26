using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Prcatice24_2PM
{
    public class Entitess
    {
        [Key]
        public int EnId { get; set; }
        [Required]
        [StringLength(50)]
        public string EnName { get; set; }
        [Required]
        [StringLength(50)]
        public string EnAddress { get; set; }

    }
}
