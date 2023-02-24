using Pawcare.Models.Base;

namespace Pawcare.Models
{
    public class Cliente:Model
    {
        public string? ClientName { get; set; }
        public string? ClientLastName { get; set; }
        public string? NumberPhone { get; set; }
        public DateTime Age { get; set; }
        
        public virtual IList<Dog>?  Dogs  { get; set; }
    }
}
