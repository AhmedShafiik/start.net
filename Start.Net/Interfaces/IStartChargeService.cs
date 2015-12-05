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
        ApiResponse<CreateChargeResponse> CreateCharge(CreateChargeRequest request);
    }
}