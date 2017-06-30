using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCore {
public enum GameError {
}

public class Flow {
    public static Flow Instance {
        get {
            if (mInstance == null)
                mInstance = new Flow();
            return mInstance;
        }
    }

    public static Flow mInstance;

    public Configuration config {
        get;
        set;
    }
    public Game game {
        get;
        set;
    }
    public GameError error {
        get;
        set;
    }
    private AppState state {
        get;
        set;
    }
    public ProgressView loadingView {
        get;
        set;
    }
    public YieldEventHandler onStartEnd {
        get;
        set;
    }

    private bool mStarted = false;

    internal Flow() {
        Updater.Instance = new Updater();
        Loader.Instance = new Loader();
        UIController.Instance = new UIController();
    }

    public IEnumerator Restart() {
        if (loadingView != null)
            loadingView.Show();
        if(!mStarted) {
            yield return UIController.Instance.Initialize();
            yield return Loader.Instance.Initialize();
            yield return Updater.Instance.Initialize();
        } else {
            yield return game.Close();
            yield return this.CloseGameStage();
        }

        game = new Game();

        if(mStarted) {
            yield return game.CheckNet();
            yield return game.CheckVersion();
        }
        yield return game.Start();

        if (onStartEnd != null)
            yield return onStartEnd.Invoke();
        mStarted = true;
        yield return null;
    }

    public IEnumerator CloseGameStage() {
        yield return UIController.Instance.CloseGameStage();
        yield return Loader.Instance.CloseGameStage();
        yield return Updater.Instance.CloseGameStage();
    }
}
}
