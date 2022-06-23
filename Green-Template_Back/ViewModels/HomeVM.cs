using Green_Template_Back.Models;
using System.Collections.Generic;

namespace Green_Template_Back.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Card> Cards { get; set; }
        public About Abouts { get; set; }
        public List<AboutList> AboutLists { get; set; }
        public List<Service> Services { get; set; }
        public Contact Contacts { get; set; }
        public Setting Settings { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
