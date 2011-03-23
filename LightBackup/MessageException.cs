using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebBackup {
    class MessageException:Exception {

        public MessageException(string message):base(message) {}
    }
}
