﻿using System;
using System.Collections.Generic;

namespace Domain.Entites
{
    public partial class User
    {
        public User()
        {
            CompanyContract = new HashSet<CompanyContract>();
            UserCompany = new HashSet<UserCompany>();
            UserStore = new HashSet<UserStore>();
            UserStoreInvite = new HashSet<UserStoreInvite>();
            Notification = new HashSet<Notification>();
    }

        public int UserId { get; set; }
        public int CountryId { get; set; }
        public int LanguageId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsAdministrator { get; set; }
        public bool IsDeleted { get; set; }  
        public DateTime LastLogin { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }

        public Country Country { get; set; }
        public Language Language { get; set; }

        public ICollection<CompanyContract> CompanyContract { get; set; }
        public ICollection<UserCompany> UserCompany { get; set; }
        public ICollection<UserStore> UserStore { get; set; }
        public ICollection<UserStoreInvite> UserStoreInvite { get; set; }
        public ICollection<Notification> Notification { get; set; }
    }
}
