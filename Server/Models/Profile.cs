namespace Chloe.Server.Models
{
    public class Profile: BaseEntity
    {
        public string Name { get; set; }
        public ProfileType ProfileType { get; set; }
    }
}
