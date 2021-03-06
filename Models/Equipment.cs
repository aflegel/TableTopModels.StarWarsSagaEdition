﻿using System;
using System.Collections.Generic;

namespace StarWarsSagaEdition.Models
{
    public partial class Equipment
    {
        public int EquipmentId { get; set; }
        public string Name { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Weight { get; set; }
        public int? AvailabilityId { get; set; }
        public int? BookId { get; set; }
        public int? Page { get; set; }
        public string Description { get; set; }
        public bool? HeadSlot { get; set; }
        public bool? BodySlot { get; set; }

        public Availability Availability { get; set; }
        public Book Book { get; set; }
    }
}
