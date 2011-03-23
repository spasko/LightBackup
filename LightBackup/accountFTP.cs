using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebBackup {
    class accountFTP {

        public string host;
        public string port;
        public string protocol;
        public int type;    // FTP, SFTP ... itd
        public string user;
        public string pass;
        public int logontype;
        public string encoding;

    }
}
