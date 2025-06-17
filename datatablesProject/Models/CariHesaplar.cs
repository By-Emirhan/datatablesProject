using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace datatablesProject.Models
{
    public class CariHesaplar
    {
        [Key]
        public int HesapID { get; set; }
        public string? CariHesapAdi { get; set; }
        public string? cariVergiNO { get; set; }
        public string? CariTelNO { get; set; }
        public string? CariAdres { get; set; }
        public string? AdresIL { get; set; }
        public string? CariILce { get; set; }
    }
}
