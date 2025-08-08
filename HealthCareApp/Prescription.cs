using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareApp
{
    internal class Prescription
    {
        int Id {  get; set; }
        public int PatientId {  get; set; }
         string MedicationName {  get; set; }
        DateTime DateIssued {  get; set; }

        public Prescription(int id, int patientId, string medicationName, DateTime dateIssued)
        {
            this.Id = id;
            this.PatientId = patientId;
            this.MedicationName = medicationName;
            this.DateIssued = dateIssued;
        }

        public override string ToString()
        {
            return $"Prescription ID: {Id}, Medication: {MedicationName}, Date: {DateIssued:yyyy-MM-dd}";
        }
    }
}
