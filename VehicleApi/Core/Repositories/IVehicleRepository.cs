﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehiclesApi.Core.Models;

namespace VehiclesApi.Core.Repositories
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<Vehicle>> GetVehiclesAsync();

        Task<Vehicle> GetVehicleAsync(string id);

        Task<Vehicle> UpdateVehicleStatus(Vehicle vehicle);

    }
}
