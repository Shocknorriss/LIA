﻿using System;
using System.Collections.Generic;

namespace Domain.Entites
{
    public partial class Industry
    {
        public Industry()
        {
            CompanyIndustry = new HashSet<CompanyIndustry>();
        }

        public int IndustryId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Description { get; set; }
        public bool IsPublished { get; set; }
        public DateTime Modified { get; set; }
        public DateTime Created { get; set; }

        public ICollection<CompanyIndustry> CompanyIndustry { get; set; }
    }
}
