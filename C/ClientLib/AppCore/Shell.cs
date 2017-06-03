using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

    public App app {
        get {
            return mApp;
        }
    }

    public AppState state {
        get {
            return mAppState;
        }
        internal set {
            mAppState = value;
        }
    }

    private App mApp;
    private Configuration mConfig = new Configuration();
    private AppState mAppState = AppState.None;

    public void RestartApp() {
        if(mApp != null) {
            mApp.Close();
            mApp = null;
        }
        mApp = new App();
        app.CheckNet();
        app.CheckVersion();
        app.Start();
    }

    public void Close() {
    }
}
}
