using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCareApp
{
    internal class HealthSystemApp
    {
        Dictionary<int, List<Prescription>> _prescriptionMap = new();
        Repository<Patient> _patientRepo = new();
        Repository<Prescription> _prescriptionRepo = new();

        public List<Prescription> GetPrescriptionsByPatientId(int patientId)
        {
            if (_prescriptionMap.TryGetValue(patientId, out var prescriptions))
            {
                return prescriptions;
            }
            else
            {
                return new List<Prescription>();
            }
        }
        public void SeedData()
        {
            _patientRepo.Add(new Patient(001, "Afia Pokuaa", 43, "Female"));
            _patientRepo.Add(new Patient(002, "John Okyere", 21, "Male"));
            _patientRepo.Add(new Patient(003, "Janet Boamah", 15, "Female"));

            _prescriptionRepo.Add(new Prescription(100, 001, "Amoxyclav", DateTime.Now.AddDays(-10)));
            _prescriptionRepo.Add(new Prescription(101, 002, "Paracetamol", DateTime.Now.AddDays(-4)));
            _prescriptionRepo.Add(new Prescription(102, 003, "Ibuprofen", DateTime.Now.AddDays(-1)));
            _prescriptionRepo.Add(new Prescription(100, 003, "Metronidazol", DateTime.Now.AddDays(-6)));
        }

        public void BuildPrescriptionMap()
        {
            var allPrescriptions = _prescriptionRepo.GetAll();

            _prescriptionMap = allPrescriptions
                .GroupBy(p => p.PatientId)
                .ToDictionary(g => g.Key, g => g.ToList());
        }

        public void PrintAllPatients()
        {
            foreach (var patient in _patientRepo.GetAll())
            {
                Console.WriteLine(patient);
            }
        }

        public void PrintPrescriptionsForPatient(int patientId)
        {
            var patient = _patientRepo.GetById(p => p.Id == patientId);

            if (patient == null)
            {
                Console.WriteLine("Patient not found.");
                return;
            }

            Console.WriteLine($"\n=== Prescriptions for {patient.Name} ===");
            var prescriptions = GetPrescriptionsByPatientId(patientId);

            if (prescriptions.Count == 0)
            {
                Console.WriteLine("No prescriptions found.");
            }
            else
            {
                foreach (var prescription in prescriptions)
                {
                    Console.WriteLine(prescription);
                }
            }
        }
    }
}
