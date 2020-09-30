using CCG.AspNetCore.Data.Auth.Model;
using System;

namespace DataModel.Tracking
{
    public interface ITrackingEntity
    {
        User LastModifiedBy { get; set; }
        DateTime LastModifiedDate { get; set; }
        User CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
    }
}