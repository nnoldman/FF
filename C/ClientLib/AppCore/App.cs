using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCore {
public class App {
    public bool CheckNet() {
        return true;
    }

    public bool CheckVersion() {
        return true;
    }

    public void Start() {
        UIManager.Instance = new UIManager();
    }
    public void Close() {
    }
    public void OnSceneOpen() {
    }
    public void OnSceneClose() {
    }
    public void OnMapLoaded() {
    }
    public void OnHeroReady() {
    }
}
}
