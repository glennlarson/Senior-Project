//Glenn Larson
//CIS591 Senior Project
//Service Ticket Class Code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Senior_Project
{
    public class TicketService
    {
        // ticket service attributes
        public TicketService()
        {
        }
        int serviceTicketID;
        public int ServiceTicketID
        {
            get { return serviceTicketID; }
            set { serviceTicketID = value; }
        }
        Employee enteredByEmployee;
        public Employee EnteredByEmployee
        {
            get { return enteredByEmployee; }
            set { enteredByEmployee = value; }
        }
        Employee serviceByEmp;
        public Employee ServicedByEmp
        {
            get { return serviceByEmp; }
            set { serviceByEmp = value; }
        }
        Customer aCust;
        public Customer ACust
        {
            get { return aCust; }
            set {aCust = value; }

        }
        CBike custBike;
        public CBike CustBike
        {
            get { return custBike; }
            set { custBike = value; }
        }
        double cost;
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        string serviceTicketDescrip;
        public string ServiceTicketDescrip
        {
            get { return serviceTicketDescrip; }
            set { serviceTicketDescrip = value; }

        }
        ArrayList sList;
        public ArrayList SList
        {
            get { return sList; }
            set { sList = value; }
        }
        // wrapper methods to access the DA
        // create ticket wrapper method
        public static string CreateTicket(TicketService aTicket)
        {
            return TicketServiceDA.CreateTicket(aTicket);
        }
        //queue tickets wrapper method
        public static ArrayList queueTickets(string status)
        {
            return TicketServiceDA.QueueTickets(status);
        }
        //update status wrapper method
        public static string UpdateStatus(TicketService aTicket, string status)
        {
            return TicketServiceDA.UpdateStatus(aTicket, status);
        }
    }
}

