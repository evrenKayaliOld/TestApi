﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBox.Business.DTO
{
    public class UserIdentifierDTO
    {
        public string Id { get; set; }
        public int Code { get; set; }
        public string UserId { get; set; }
        public DateTime Time { get; set; }
        public DateTime Expire { get; set; }

    }
}
