using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sima.App.Dominio
{
    public class User : Employee
    {   
        int Id {get; set; }
        
        new string Password {get; set;} = null!;
    }
}