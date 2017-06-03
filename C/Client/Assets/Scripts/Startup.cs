using UnityEngine;
using System.Collections;
using AppCore;
public class Startup : MonoBehaviour {
    public Shell shell;
    void Awake() {
        shell = new Shell();
        shell.RestartApp();
        var state = shell.state;
        UIManager.Instance
    }
    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {

    }
}

