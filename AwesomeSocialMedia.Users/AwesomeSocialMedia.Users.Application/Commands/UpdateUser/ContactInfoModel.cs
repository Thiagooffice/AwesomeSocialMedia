using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeSocialMedia.Users.Core.ValueObjects;

namespace AwesomeSocialMedia.Users.Application.Commands.UpdateUser
{
    public class ContactInfoModel
    {
        public string Email { get; set; }
        public string Website { get; set; }
        public string PhoneNumber { get; set; }

        public ContactInfo ToValueObject() => new ContactInfo(Email, Website, PhoneNumber);
    }
}