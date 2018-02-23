using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HumanInterface : Interface {
    public override void QueryEnv() {
    }

    public override PlayerCommands Control(PlayerData data) {
        PlayerCommands cmds;
        cmds.forward = Input.GetKey("w");
        cmds.backward = Input.GetKey("s");
        cmds.left = Input.GetKey("a");
        cmds.right = Input.GetKey("d");
        return cmds;
    }
}
