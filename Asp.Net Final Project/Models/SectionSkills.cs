﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_Final_Project.Models
{
    public class SectionSkills
    {
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string SectionName { get; set; }

        public virtual ICollection<SkillsProgressBar> SkillsProgressBar { get; set; }
        public virtual ICollection<SkillsChart> SkillsChart { get; set; }
    }
}
