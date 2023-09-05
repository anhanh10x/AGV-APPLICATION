using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class Information
    {
        private string fullName = "";
        private string address = "";
        private string email = "";
        private string major = "";
        private string phone = "";
        private string imagePath = "";
        private string username = "";
        public string FullName { get => fullName; set => fullName = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Major { get => major; set => major = value; }
        public string Phone { get => phone; set => phone = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public string Username { get => username; set => username = value; }
    }
}
