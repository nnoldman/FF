using UnityEngine;
using System.Collections;
using AppCore;
public class Startup : MonoBehaviour {
    public Shell shell;

    void Awake() {
        shell = new Shell();
        StartCoroutine(shell.RestartApp());
    }

    void Start() {
        var state = shell.state;
        UIManager.Instance.Initialize();
    }

    void Update() {
    }
}

