﻿using eShopSolution.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Slide
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public string Url { set; get; }
        public int SortOrder { get; set; }
        public string Image { get; set; }
        public Status Status { set; get; }
    }
}