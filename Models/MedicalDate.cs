using Pawcare.Models.Base;

namespace Pawcare.Models
{
    public class MedicalDate:Model
    {
        public DateTime Date { get; set; }
        public string? Notes { get; set; }
    }
}
