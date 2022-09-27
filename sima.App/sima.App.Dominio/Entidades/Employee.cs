using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace sima.App.Dominio
{
    public class Employee
    {
        [Required, StringLength(155)]
        public string FirstName { get; set; } = null!;

        [StringLength(155)]
        public string MiddleName { get; set; } = null!;

        [Required, StringLength(155)]
        public string FirstSurname { get; set; } = null!;

        [StringLength(155)]
        public string SecondSurname { get; set; } = null!;

        [Required, StringLength(155)]
        public string TypeId { get; set; } = null!;

        [Key]
        [StringLength(10, MinimumLength = 6)]
        public string EmployeeId { get; set; } = null!;

        [Phone, StringLength(7, MinimumLength = 10)]
        public int Phone { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;
        [Required]
        public string LevelEdu { get; set; } = null!;

        [Required]
        public string Position { get; set; } = null!;

        [Required]
        public string City { get; set; } = null!;

        [Required, StringLength(155)]
        public string Address { get; set; } = null!;

        [Required]
        public string Branch { get; set; } = null!;


        [Required, DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string PasswordConfirm { get; set; } = null!;

    }
}

