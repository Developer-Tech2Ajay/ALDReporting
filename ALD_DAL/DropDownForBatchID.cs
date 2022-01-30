﻿using ALD_Entities;
using ALD_Entities.Util;
using System.Collections.Generic;

namespace ALD_DAL
{
    public class DropDownForBatchId
    {
        public List<AllDropDownData> GetAllDropDownValues()
        => DbAccess.GetApplicationData<AllDropDownData>(Constants.GetAllBatchId, Constants.ConnStringReport);
    }
}
