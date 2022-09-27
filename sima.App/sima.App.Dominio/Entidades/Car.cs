using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
//using System.Globalization;


namespace sima.App.Dominio
{
    public class Car : Customer
    {
        public string VehiclePlate { get; set; } = null!;
        public string Manufacturer { get; set; } = null!;
        public string Line { get; set; } = null!;
        public string CylinderCap { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Service { get; set; } = null!;
        public string BodyType { get; set; } = null!;
        public string Fuel { get; set; } = null!;
        public string Capacity { get; set; } = null!;
        public string EngineId { get; set; } = null!;
        public string SerieNum { get; set; } = null!;
        public string ChasisNum { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Owner { get; set; } = null!;
        public string OwnerId { get; set; } = null!;
    }
}