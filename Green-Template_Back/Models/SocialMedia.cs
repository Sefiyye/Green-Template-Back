namespace Green_Template_Back.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public int SettingId { get; set; }
        public Setting Setting { get; set; }
    }
}
