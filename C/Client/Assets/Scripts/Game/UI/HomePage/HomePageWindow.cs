using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class HomePageWindow: View<LoginSystem> {
    HomePage.Main mWindow;

    protected override void OnInit() {
        HomePage.HomePageBinder.BindAll();
        //mWindow = HomePage.Main.CreateInstance();
        //this.contentPane = mWindow.asCom;
        //mWindow.login.onClick.Add(Login);
        //mWindow.exit.onClick.Add(Application.Quit);
    }

    void Login() {
        controller.Login(mWindow.user.text, mWindow.psw.text);
    }
}
