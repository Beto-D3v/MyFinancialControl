using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFinancialControl.Server.Models
{
    [Table("Expenses")]
    public class ExpenseModel
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Payer { get; set; }
        public string TagName { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
       

        public ExpenseModel(Guid id,string name, string payer, string tagName, double value, DateTime date)
        {
            Id = id;
            Name = name;
            Payer = payer;
            TagName = tagName;
            Value = value;
            Date = date;
        }

    }
}
