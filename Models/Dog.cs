using Microsoft.AspNetCore.Components.Server.Circuits;
using Pawcare.Models.Base;

namespace Pawcare.Models
{
    public class Dog:Model
    {
        public string? DogName { get; set; }
        public DateTime Birthday { get; set; }
        public int Weight { get; set; }
        public string? Race { get; set; }
        public int IdClient { get; set; }
        public string? Photo { get; set; }
        public int MedicDatesId { get; set; }
        public int MedicalRecordsId { get; set; }
        public int DewormingId { get; set; }

        public virtual Cliente? Client { get; set; } 
        public virtual MedicalDate? MedicalDate { get; set; } 
        public virtual MedicalRecords? MedicalRecords { get; set; } 
        public virtual Deworming? Deworming { get; set; } 


    }
}
