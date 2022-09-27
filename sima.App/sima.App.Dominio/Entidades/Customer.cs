using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//using System.Globalization;


namespace sima.App.Dominio
{
    public class Customer
    {
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null;
        public string FirstSurname { get; set; } = null!;
        public string SecondSurname { get; set; } = null;
        public string TypeId { get; set; } = null!;
        public string Id { get; set; } = null!;
        public int Phone { get; set; }
        public string Email { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string password { get; set; } = null!;
    }
}