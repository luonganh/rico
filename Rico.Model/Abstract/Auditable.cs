using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rico.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }
        [MaxLength(256)]
        public string CreateBy { set; get; }
        [MaxLength(256)]
        public string UpdatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
    }
}
