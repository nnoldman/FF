using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GameSystem : SystemBase, IEventSender {
    public static T Get<T>() where T : GameSystem {
        return default(T);
    }

    public void Trigger(int id, object data) {
        throw new NotImplementedException();
    }

    protected void BindCommand<T>(CommandID id, Action<T> callback) where T : ICommand {
        Commands.Instance.Bind((int)id, callback);
    }
}
