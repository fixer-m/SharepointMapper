using System;
using Shmapper;

namespace SpTest
{
    [SharepointList("Блок страницы вендора")]
    public class SpVendorBlock : ISharepointItem
    {
        [SharepointField("ID")]
        public int Id { get; set; }

        [SharepointField("Title")]
        public string Title { get; set; }

        private Func<int, int> getAu;
        public int MontBlockAudienceLookUp => getAu(Id);
    }
}