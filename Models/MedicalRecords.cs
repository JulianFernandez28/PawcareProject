using Pawcare.Models.Base;

namespace Pawcare.Models
{
    public class MedicalRecords:Model
    {
        public string? Vaccines { get; set; }
        public string? Deworming { get; set; }
        public string? Medicines { get; set; }
    }
}
