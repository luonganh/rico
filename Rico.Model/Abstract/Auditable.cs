﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Rico.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [MaxLength(256)]
        public string CreateBy { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        public bool Status { set; get; }
    }
}