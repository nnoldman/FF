using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Updater: GameController {
    public static Updater Instance {
        internal set;
        get;
    }

    public override IEnumerator CloseGameStage() {
        yield return null;
    }

    public override IEnumerator Initialize() {
        yield return null;
    }
}
