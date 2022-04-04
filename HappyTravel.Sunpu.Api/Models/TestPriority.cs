using HappyTravel.Sunpu.Data.Models;

namespace HappyTravel.Sunpu.Api.Models
{
    public class TestPriority
    {
        public string SupplierCode { get; set; } = string.Empty;
        public PriorityTypes Priority { get; set; }
        public int Order { get; set; }
    }
}
