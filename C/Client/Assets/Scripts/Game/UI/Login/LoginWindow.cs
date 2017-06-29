using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class LoginWindow : View<LoginSystem> {
    public GameObject user;
    public GameObject psw;

    protected override void OnStart() {
    }

    protected override void OnShown() {
        SetUser(controller.user, controller.passWord);
    }

    public void SetUser(string user, string psw) {
        this.user.name = user;
        this.psw.name = psw;
    }

    protected override void BindListeners() {
    }

    void OnCommand(GameObject go) {
        controller.Login(user.name, psw.name);
    }


}
