﻿using Start.Net.Entities;
using Start.Net.RequestModels;
using Start.Net.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.Net.Interfaces
{
    public interface IStartChargeService
    {
        ApiResponse<Charge> CreateCharge(CreateChargeRequest request);

        ApiResponse<Charge> GetCharge(GetChargeRequest request);

        ApiResponse<List<Charge>> ListCharges(ListChargesRequest request);
    }
}
