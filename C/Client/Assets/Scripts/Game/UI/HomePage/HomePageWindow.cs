using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class HomePageWindow: View<LoginSystem> {
    HomePage.Main window {
        get {
            return (HomePage.Main)this.panel.ui;
        }
    }

    public HomePageWindow() {
        HomePage.HomePageBinder.BindAll();
    }

    protected override void OnInit() {
        window.login.onClick.Add(Login);
    }

    void Login() {
        controller.Login(window.user.text, window.psw.text);
    }
}
