using System;

namespace MHCMS.Domain
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Guid UniqeId { get; set; } = Guid.NewGuid();
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateModified { get; set; }
    }
}
