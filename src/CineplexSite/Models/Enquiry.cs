﻿using System;
using System.Collections.Generic;

namespace CineplexSite.Models
{
    public partial class Enquiry
    {
        public int EnquiryId { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
