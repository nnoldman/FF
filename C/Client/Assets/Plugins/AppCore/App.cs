using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCore {
public class App {
    private SceneParam mSceneParam;

    public IEnumerator CheckNet() {
        yield return 0;
    }

    public IEnumerator CheckVersion() {
        yield return 0;
    }

    public IEnumerator Start() {

        yield return 0;
    }

    public IEnumerator LoadScene(SceneParam param) {
        mSceneParam = param;
        OnSceneClose();
        yield return null;
        OnSceneOpen();
        yield return null;
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
