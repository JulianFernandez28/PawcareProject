using Pawcare.Models.Base;

namespace Pawcare.Models
{
    public class Deworming:Model
    {
        public DateTime Date { get; set; }
        public string? Notes { get; set; }
        public string? Frecuency { get; set; }
    }
}
