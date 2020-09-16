using CCG.AspNetCore.Data.Auth.Model;
using System;

namespace DataModel.Tracking
{
    public class TrackingEntity: ITrackingEntity
    {
        public virtual User LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public virtual User CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}