using Pawcare.Models.Base;

namespace Pawcare.Models
{
    public class Reminders:Model
    {
        public int MedicalDateId { get; set; }
        public int EsteticDateaId{ get; set; }
        public int DogId { get; set; }

        public MedicalDate? MedicalDate { get; set; } 
        public EsteticDates? EsteticDates { get; set; }
        public Dog? Dog { get; set; } 
    }
}
