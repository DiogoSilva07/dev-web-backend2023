using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dev_web_backend2023.Models
{
    [Table("Veículos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Placa")]
        public int Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano de Fabricação")]
        public int AnoFabricação { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Ano Modelo")]
        public int AnoModelo { get; set; }
    }
}
