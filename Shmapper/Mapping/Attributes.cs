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

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class SharepointListAttribute : Attribute
    {
        public string Title { get; private set; }
        public Guid Id { get; private set; }
        public SpecialList SpecialList { get; private set; }

        public SharepointListAttribute(string Title)
        {
            this.Title = Title;
        }

        public SharepointListAttribute(Guid Id)
        {
            this.Id = Id;
        }

        public SharepointListAttribute(SpecialList SpecialList)
        {
            this.SpecialList = SpecialList;
        }
    }
}
