using System;

namespace Shmapper
{
    /// <summary>
    /// Maps class to Sharepoint list by Title, Guid or SpecialList
    /// </summary>
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
