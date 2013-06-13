//Glenn Larson
//CIS591 Senior Project
//Service Class Codeusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Senior_Project
{
    public class Service
    {

        int serviceID;
        public int ServiceID
        {
            get { return serviceID; }
            set { serviceID = value; }
        }
        string serviceName;
        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; }
        }
        string serviceType;
        public string ServiceType
        {
            get { return serviceType; }
            set { serviceType = value; }

        }
        string serviceDescrip;
        public string ServiceDescrip
        {
            get { return serviceDescrip; }
            set { serviceDescrip = value; }
        }
        double serviceCost;
        public double ServiceCost
        {
            get { return serviceCost; }
            set { serviceCost = value; }
        }
        //wrapper methods
        //add service wrapper method
        public static string addService(Service aService)
        {
            return ServiceDA.addService(aService);
        }
        //select all services wrapper methods
        public static ArrayList allServices()
        {
            return ServiceDA.allServices();
        }
        //update service wrapper method
        public static string UpdateService(Service aService)
        {
            return ServiceDA.UpdateService(aService);
        }
        //delete service wrapper method
        public static string DeleteService(int sNum)
        {
            return ServiceDA.DeleteService(sNum);
        }
        //get services that are used in a service ticket
        public static ArrayList GetServices(ArrayList sList)
        {
            return ServiceDA.GetServices(sList);
        }
    }
}

