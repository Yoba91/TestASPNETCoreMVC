using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProjectASP.NET_MVC.Models
{
    public class Repository
    {
        private static IList<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses
        {
            get { return responses; }
        }
        public static void AddResponse (GuestResponse guestResponse)
        {
            responses.Add(guestResponse);
        }
    }
}
