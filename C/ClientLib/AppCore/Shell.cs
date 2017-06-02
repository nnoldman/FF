using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore {
public class Shell {
    public Configuration config {
        get {
            return mConfig;
        }
        set {
            mConfig = value;
        }
    }
    private Configuration mConfig = new Configuration();
    public void RestartApp() {
    }
    public void Close() {
    }
}
}
