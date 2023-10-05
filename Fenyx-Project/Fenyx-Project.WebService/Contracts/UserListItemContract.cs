using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Fenyx_Project.WebService.Contracts
{
    [DataContract]  
    public class UserListItemContract
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public DateTime Birthdate { get; set; }
        [DataMember]
        public string PhotoUrl { get; set; }
    }
}