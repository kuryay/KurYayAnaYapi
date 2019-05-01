using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurYayAnaYapi.Models.Concrete
{
    public class Information : BaseEntity
    {
        public string NameSurname { get; set; }
        public string MailAdress { get; set; }
        public string WebsiteTitle { get; set; }
        public string WebsiteSubtitle { get; set; }
        public string WebsiteDescription { get; set; }

        public Information()
        {
                
        }

        public Information(string NameSurname, string MailAdress, string WebsiteTitle, string WebsiteSubtitle, string WebsiteDescription)
        {
            this.NameSurname = NameSurname;
            this.MailAdress = MailAdress;
            this.WebsiteTitle = WebsiteTitle;
            this.WebsiteSubtitle = WebsiteSubtitle;
            this.WebsiteDescription = WebsiteDescription;
        }
    }
}
