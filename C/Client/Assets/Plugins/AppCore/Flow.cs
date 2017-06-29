using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCore {
public class Flow {
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

    public YieldEventHandler onStartEnd;
    public ProgressView updataView;

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

    public IEnumerator Restart() {
        bool updata = false;
        if(mApp != null) {
            mApp.Close();
            mApp = null;
        } else {
            updata = true;
        }
        mApp = new App();
        if(updata) {
            yield return app.CheckNet();
            yield return app.CheckVersion();
        }
        yield return app.Start();
        if (onStartEnd != null)
            yield return onStartEnd.Invoke();
        yield return null;
    }

    public void Close() {
        Loader.Instance = new Loader();
    }
}
}
