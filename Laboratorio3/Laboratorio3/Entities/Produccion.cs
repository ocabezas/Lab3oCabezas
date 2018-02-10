using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3.Entities
{
    class Produccion : BaseEntity
    {
        public int iD { get; set; }
        public DateTime productionDate { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public int Value { get; set; }
        public int idAnimal { get; set; }


        public Produccion()
        {

        }
    }
}
