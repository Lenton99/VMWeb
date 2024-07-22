using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VMWeb.Models
{
    [Table("T_Contact")]
    public class Contact
    {
        [Key]
        [Column("record_id")]
        [Range(1, int.MaxValue, ErrorMessage = "Record ID must be a positive integer.")]
        public int RecordId { get; set; }

        [Column("pos_id")]
        [Range(1, int.MaxValue, ErrorMessage = "POS ID must be a positive integer.")]
        public int? PosId { get; set; }

        [Column("customer_id")]
        [Range(1, int.MaxValue, ErrorMessage = "Customer ID must be a positive integer.")]
        public int? CustomerId { get; set; }

        [Column("forename")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Forename must be between 2 and 100 characters.")]
        public string? Forename { get; set; }

        [Column("surname")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Surname must be between 2 and 100 characters.")]
        public string? Surname { get; set; }

        [Column("job_title")]
        [StringLength(100, ErrorMessage = "Job title cannot exceed 100 characters.")]
        public string? JobTitle { get; set; }

        [Column("tel")]
        [Phone(ErrorMessage = "Invalid telephone number.")]
        public string? Tel { get; set; }

        [Column("mobile")]
        [Phone(ErrorMessage = "Invalid mobile number.")]
        public string? Mobile { get; set; }

        [Column("email")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? Email { get; set; }

        [Column("fax")]
        [Phone(ErrorMessage = "Invalid fax number.")]
        public string? Fax { get; set; }

        [Column("notes")]
        [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters.")]
        public string? Notes { get; set; }

    }
}
