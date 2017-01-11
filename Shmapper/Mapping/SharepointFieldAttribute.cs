using System;

namespace Shmapper
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class SharepointFieldAttribute : Attribute
    {
        public string InternalName { get; set; }
        public BindData BindData { get; set; }

        public SharepointFieldAttribute(string internalName)
        {
            this.InternalName = internalName;
            this.BindData = BindData.Default;
        }

        public SharepointFieldAttribute(string internalName, BindData whatToRead)
        {
            this.InternalName = internalName;
            this.BindData = whatToRead;
        }
    }
}
