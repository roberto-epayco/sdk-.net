﻿using System.Collections.Generic;
using EpaycoSdk.Models.Bank;

namespace EpaycoSdk.Models.Cash
{
    public class CashSplitModel
    {
        public string splitpayment { get; set; }
        public string split_app_id { get; set; }
        public string split_merchant_id { get; set; }
        public string split_type { get; set; }
        public string split_primary_receiver { get; set; }
        public string split_primary_receiver_fee { get; set; }
        public List<SplitReceivers> split_receivers { get; set; }
    }
}