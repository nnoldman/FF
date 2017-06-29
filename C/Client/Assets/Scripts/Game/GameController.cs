using AppCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

//public class GameController: GameSystem {

//    public override void BindListeners() {
//        {
//            var controller = Get<LoginSystem>();
//            controller.onLoginReturn += GameController_onLoginReturn;
//        }
//    }

//    private void GameController_onLoginReturn() {
//        var ctrler = GameSystem.Get<LoginSystem>();
//        if (ctrler.returnCode == LOGIN_RETURN_CODE.LOGIN_RETURN_SUCESS) {
//            if (ctrler.roleIndex == -1) {
//                UIController.Instance.Show<CreateRoleWindow>();
//            } else {
//                UIController.Instance.Show<SelectWindow>();
//            }
//        } else {
//            UIController.Instance.Get<MessageBox>().ShowError(ctrler.returnCode.ToString());
//        }
//    }


//}
