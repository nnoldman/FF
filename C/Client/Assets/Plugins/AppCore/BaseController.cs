using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class BaseController {
    public abstract IEnumerator OnGameStageClose();
    public abstract IEnumerator Initialize();
}
