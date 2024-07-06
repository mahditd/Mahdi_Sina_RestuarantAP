using Mahdi_Sina_AP_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Sina_Mahdi_RestaurantAP
{
    public class Admin : User
    {
        public static Admin currentAdmin;
        List<Complaint> listConverterToComplaint(string Str)
        {
            if (complaintListJson == null)
            {
                return new List<Complaint>();
            }
            return JsonSerializer.Deserialize<List<Complaint>>(Str);
        }

        string stringConverterToComplaint(List<Complaint> list)
        {
            return JsonSerializer.Serialize(list);
        }
        public string complaintListJson { get; set; }
        [NotMapped]
        public List<Complaint> complaints {  get => listConverterToComplaint(complaintListJson) ; set => complaintListJson = stringConverterToComplaint(value); }
        public Admin() { }
        public Admin(string userName, string password) : base(userName, password)
        {
            complaints = new List<Complaint>();
        }
    }
}
