using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebBackup {
    class ServiceManager {

        private List<Service> serwices = null ;

        private static ServiceManager obj = null;

        private ServiceManager() {
            serwices = new List<Service>();  
        }


        public static ServiceManager getDefault() {
            if (obj == null) {
                obj = new ServiceManager();
            }
            return obj;
        }

        public bool addService(Service serv) {
            foreach (Service s in serwices) {
                if (s.name == serv.name) {
                    throw new MessageException( "Service name exists, Please change !!!" );
                }
            }
            serwices.Add(serv);
            Logger.logInfo("add new service: " + serv.name );
            return true;
        }


    }
}
