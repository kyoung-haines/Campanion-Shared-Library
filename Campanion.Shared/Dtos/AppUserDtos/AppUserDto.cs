using System;
using System.Collections.Generic;
using System.Text;

namespace Campanion.Shared.Dtos.AppUserDtos
{
    public class AppUserDto()
    {
        public string AppUserEmail { get; set; }
        public string AppUserPhone { get; set; }
        public string AppUserType { get; set; }
        public string AppUserFirstName { get; set; }
        public string AppUserLastName { get; set; }
        public string AppUserStreetAddress { get; set; }
        public string AppUserCity { get; set; }
        public string AppUserProvince { get; set; }
        public string AppUserCountry { get; set; }
        public string AppUserPostalCode { get; set; }  
        public List<string> AppUserFavouriteCampgrounds { get; set; }
    }
}
