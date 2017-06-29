using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class GameController {
    public abstract IEnumerator CloseGameStage();
    public abstract IEnumerator Initialize();
}
