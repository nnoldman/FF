using UnityEngine;
using System.Collections;
using AppCore;
public class Startup : MonoBehaviour {
    void Awake() {
        Flow.Instance.onStartEnd += OnStartEnd;
        StartCoroutine(Flow.Instance.Restart());
    }

    IEnumerator OnStartEnd() {
        UIController.Instance.Show<HomePageWindow>();
        yield return null;
    }
}

