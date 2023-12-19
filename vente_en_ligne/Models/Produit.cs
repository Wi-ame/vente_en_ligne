using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace vente_en_ligne.Models
{
    public class Produit
    {
        [Key]
        public int IdPr { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double prix { get; set; }

        [ForeignKey("Categorie")]
        public int IDC { get; set; }
        public Categories Categories { get; set; }

        [ForeignKey("Proprietaire")]
        public string IDP { get; set; }
        public Proprietaire proprietaires { get; set; }
        public DateTime DateDepot { get; set; }
        public byte[] ImageData { get; set; }
        public int stock { get; set; }

    }
}
