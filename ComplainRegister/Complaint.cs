using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplainRegister
{
    class Complaint
    {
        private string clientName, details, date, status, engineers, technicians, product, cityregion, email, contact;


        public Complaint(string clientName, string contact, string details, string product, string date, string status, string engineers, string technicians, string cityregion, string email)
        {
            this.clientName = clientName;
            this.details = details;
            this.date = date;
            this.contact = contact;
            this.status = status;
            this.engineers = engineers;
            this.technicians = technicians;
            this.cityregion = cityregion;
            this.product = product;
            this.email = email;
        }

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }
        public string CityRegion
        {
            get { return cityregion; }
            set { cityregion = value; }
        }
        public string Product
        {
            get { return product; }
            set { product = value; }
        }
        public string Details
        {
            get { return details; }
            set { details = value; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public string Technicians
        {
            get { return technicians; }
            set { technicians = value; }
        }
        public string Engineers
        {
            get { return engineers; }
            set { engineers = value; }
        }
    }
}
