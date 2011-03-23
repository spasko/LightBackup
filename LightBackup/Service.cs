using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebBackup {
    class Service {

        enum KIND { ALL,  ONLYFTP, onlyDB }

        public string name;                 // unikalna nazwa
        public string comments;      // opis
        accountFTP fromFTP = null;   // konto ftp z którego robimy backup
        accountDB fromDB = null;     // konto bazodanowe z którego robimy backup
        KIND kind = KIND.ALL;        // rodzaj dodanego serwisu

        int diffDay = 1;             // Co ile dni należy robić backup
        DateTime last = DateTime.MinValue;  // czas ostatniego backupu

        


    }
}
