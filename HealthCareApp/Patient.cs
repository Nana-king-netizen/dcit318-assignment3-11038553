using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareApp
{
    internal class Patient
    {
         public int Id { get; set; }
        public string Name {  get; set; }
         int Age {  get; set; }
        string Gender {  get; set; }

        public Patient(int id, string name, int age, string gender)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Gender: {Gender}";
        }

    }
}
