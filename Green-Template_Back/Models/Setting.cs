using System.Collections.Generic;

namespace Green_Template_Back.Models
{
    public class Setting
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string HeaderLogo { get; set; }
        public string FooterLogo { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }

    }
}
