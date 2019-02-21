using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Pets
    {
        public int PetId { get; set; }
        public string PetName { get; set; }
        public string PetStartTime { get; set; }
        public string PetInType { get; set; }
        public string PetType { get; set; }
        public Nullable<int> PetInventory { get; set; }
        public string PetBodily { get; set; }
        public Nullable<double> PetPrice { get; set; }
        public Nullable<int> PetState { get; set; }
        public Nullable<int> UsersId { get; set; }
    }
}
