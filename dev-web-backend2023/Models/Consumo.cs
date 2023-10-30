using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dev_web_backend2023.Models
{ 
    [Table ("Consumos")]
    public class Consumo
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar descrição")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar data")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a kilometragem")]
        public int Km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel Tipo { get; set; }

        [Display(Name = "Veículo")]
        [Required(ErrorMessage = "Obrigatório informar o Veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey ("VeiculoId")]
        public Veiculo Veiculo { get; set; }

    }

    public enum TipoCombustivel 
    { 
        Gasolina,
        Diesel,
        Etanol
    }
}
