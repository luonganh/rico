using System;

namespace Rico.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? UpdatedDate { set; get; }
        string CreateBy { set; get; }
        string UpdatedBy { set; get; }
        DateTime? CreatedDate { set; get; }
    }
}