using FairyGUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace AppCore {

public class UIController: ControllerBase {
    public static UIController Instance {
        internal set;
        get;
    }

    public ProgressView currentProgressView;

    public Dictionary<string, ViewBase> mViews = new Dictionary<string, ViewBase>();

    public T Show<T>() where T : ViewBase, new() {
        T ret = Get<T>();
        if(ret != null) {
            ret.Show();
        }
        return ret;
    }

    public T Hide<T>() where T : ViewBase, new() {
        return default(T);
    }

    public T Get<T>() where T : ViewBase, new() {
        ViewBase ret;
        string name = typeof(T).Name;
        if (!mViews.TryGetValue(name, out ret)) {
            ret = LoadView<T>(name);
            if(ret != null) {
                mViews.Add(name, ret);
            }
        }
        if (ret != null)
            return (T)ret;
        else
            return null;
    }

    public T LoadView<T>(string name) where T : ViewBase, new () {
        var sceneObject = Loader.Instance.CreateObject<GameObject>(name);
        if (!sceneObject)
            return null;
        var panel = sceneObject.GetComponent<UIPanel>();
        if (panel == null)
            return null;
        T ret = new T();
        ret.panel = panel;
        return ret;
    }

    public override bool Initialize() {
        GRoot.inst.SetContentScaleFactor(1136, 640);
        return true;
    }

    public override void Update() {
    }
}
}
