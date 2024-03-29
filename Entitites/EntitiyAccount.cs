﻿
namespace Korepetycje_Matematyka.Entitites
{
    public class EntitiyAccount
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Login { get; set; }
        [Required]
        public string? Password { get; set; }
        [Phone]
        public string? PhoneNumber { get; set; }
        [MaxLength(250)]
        public string? Desc { get; set; }
    }
}

