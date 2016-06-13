using System;

namespace Rico.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }

        DateTime? UpdatedDate { set; get; }

        string CreateBy { set; get; }

        string UpdatedBy { set; get; }
        
        string MetaKeyword { get; set; }

        string MetaDescription { get; set; }

        bool Status { get; set; }
    }
}