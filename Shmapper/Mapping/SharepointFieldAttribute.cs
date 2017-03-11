using System;

namespace Shmapper
{
    /// <summary>
    /// Maps property to Sharepoint field by internal name 
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class SharepointFieldAttribute : Attribute
    {
        public string InternalName { get; set; }
        public MapData MapData { get; set; }

        public SharepointFieldAttribute(string internalName)
        {
            this.InternalName = internalName;
            this.MapData = MapData.Default;
        }

        public SharepointFieldAttribute(string internalName, MapData whatToRead)
        {
            this.InternalName = internalName;
            this.MapData = whatToRead;
        }
    }
}
