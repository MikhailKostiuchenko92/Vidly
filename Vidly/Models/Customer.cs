﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Name.")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        [Min18YearsIfAMember]
        public DateTime? birthDate { get; set; }

        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }
    }
}