﻿using System.Collections.Generic;
using System.Linq;

namespace ShipIt.Models.ApiModels
{
    public class OutboundOrderResponse
    {
        public int NumberOfTrucks => Trucks.Count();
        public IEnumerable<TruckManifestModel> Trucks { get; set; }
    }
}