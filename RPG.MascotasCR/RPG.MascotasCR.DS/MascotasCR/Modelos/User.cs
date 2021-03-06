﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.MascotasCR.DS.MascotasCR.Modelos
{
    [Table("User")]
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Active { get; set; }
        public int RolID { get; set; }

    }
}