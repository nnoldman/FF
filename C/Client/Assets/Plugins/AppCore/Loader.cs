using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Loader : ControllerBase {
    public static Loader Instance {
        internal set;
        get;
    }

    public override bool Initialize() {
        throw new NotImplementedException();
    }

    public override void Update() {
        throw new NotImplementedException();
    }

    public T CreateObject<T>(string pathName) where T : UnityEngine.Object {
        var prefab = LoadPrefab<T>(pathName);
        if (prefab)
            return GameObject.Instantiate(prefab);
        return null;
    }
    public T LoadPrefab<T>(string pathName) where T : UnityEngine.Object {
        return (T)Resources.Load<T>(pathName);
    }
}
