using System;

namespace Shmapper
{
    public interface ISharepointItem
    {
        int Id { get; set; }

        /*
        public virtual int Id { get; protected internal set; }
        public virtual string Title { get; set; }
        public virtual DateTime Created { get; protected internal set; }
        public virtual User Author { get; protected internal set; }
        public virtual DateTime Modified { get; protected internal set; }
        public virtual User Editor { get; protected internal set; }
        public virtual Version Version { get; protected internal set; }
        public virtual Guid Guid { get; protected internal set; }
        */
    }
}
