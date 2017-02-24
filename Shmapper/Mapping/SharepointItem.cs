using System;

namespace Shmapper
{
    /// <summary>
    /// Basic interface that should be implemented for every mapped class
    /// </summary>
    public interface ISharepointItem
    {
        int Id { get; set; }
    }
}
