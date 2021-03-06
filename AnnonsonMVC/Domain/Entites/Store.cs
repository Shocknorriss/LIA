﻿using System;
using System.Collections.Generic;

namespace Domain.Entites
{
    public partial class Store
    {
        public Store()
        {
            StoreArticle = new HashSet<StoreArticle>();
            UserStore = new HashSet<UserStore>();
            BonusStore = new HashSet<BonusStore>();
            MallStore = new HashSet<MallStore>();
            NotificationHub = new HashSet<NotificationHub>();
            StoreSubscription = new HashSet<StoreSubscription>();
            UserStoreInvite = new HashSet<UserStoreInvite>();
        }

        public int StoreId { get; set; }
        public int CompanyId { get; set; }
        public int MunicipalityId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public string ImageFileName { get; set; }
        public string ImageFileFormat { get; set; }
        public string ImageWidths { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Address { get; set; }
        public string AddressExtra { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Homepage { get; set; }
        public string OpeningHoursDescription { get; set; }
        public TimeSpan MondayBegin { get; set; }
        public TimeSpan MondayEnd { get; set; }
        public TimeSpan TuesdayBegin { get; set; }
        public TimeSpan TuesdayEnd { get; set; }
        public TimeSpan WednesdayBegin { get; set; }
        public TimeSpan WednesdayEnd { get; set; }
        public TimeSpan ThursdayBegin { get; set; }
        public TimeSpan ThursdayEnd { get; set; }
        public TimeSpan FridayBegin { get; set; }
        public TimeSpan FridayEnd { get; set; }
        public TimeSpan SaturdayBegin { get; set; }
        public TimeSpan SaturdayEnd { get; set; }
        public TimeSpan SundayBegin { get; set; }
        public TimeSpan SundayEnd { get; set; }
        public DateTime PublishBegin { get; set; }
        public DateTime PublishEnd { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deleted { get; set; }
        public int? MallId { get; set; }
        public int? IndustryId { get; set; }
        public string AppleId { get; set; }
        public string AndroidId { get; set; }
        public string AppIcon { get; set; }
        public string StoreLink { get; set; }
        public string PlayLink { get; set; }
        public string StoreImageUrl { get; set; }

        public Company Company { get; set; }
        public ICollection<StoreArticle> StoreArticle { get; set; }
        public ICollection<UserStore> UserStore { get; set; }
        public Municipality Municipality { get; set; }
        public ICollection<BonusStore> BonusStore { get; set; }
        public ICollection<MallStore> MallStore { get; set; }
        public ICollection<NotificationHub> NotificationHub { get; set; }
        public ICollection<StoreSubscription> StoreSubscription { get; set; }
        public ICollection<UserStoreInvite> UserStoreInvite { get; set; }
    }
}
