using System.Collections.Generic;

namespace ITMO.ADO.NET.EF.FinalTest.Crewing
{
    public class Vessel
    {
        public int VesselId { get; set; }
        public string VesselName { get; set; }
        public string CrewingManager { get; set; }
        public ICollection<Seafarer> Seafarers { get; set; }

        public override string ToString()
        {
            return VesselName.ToString();
        }
    }
}
