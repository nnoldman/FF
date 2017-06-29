using UnityEngine;
using System.Collections;
using AppCore;
public class Startup : MonoBehaviour {
    public Flow shell;

    void Awake() {
        shell = new Flow();
        shell.onStartEnd += OnStartEnd;
        StartCoroutine(shell.Restart());
    }

    IEnumerator OnStartEnd() {
        UIController.Instance.Show<HomePageWindow>();
        yield return null;
    }
}

