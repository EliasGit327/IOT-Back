#nullable enable
namespace IOT_Back.Models
{
    public interface DeviceDto
    {
        public string Name { get; set; }
        public string? BoardName { get; set; }
        public string Value { get; set; }
    }
}