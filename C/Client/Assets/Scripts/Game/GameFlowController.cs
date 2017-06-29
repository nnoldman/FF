using AppCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class GameController: GameSystem {
    public void OnApplicationRestartEnd() {
        UIController.Instance.Show<HomePageWindow>();
    }

    public void Quit() {
        Application.Quit();
    }
}
