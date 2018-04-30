using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cmds : MonoBehaviour {
    public Image accel_top, accel_bottom, brakes, nitro, turn_left, turn_right;

    public void ShowCmds(PlayerCommands cmds) {
        brakes.fillAmount = cmds.brake;
        nitro.fillAmount = cmds.nitro;
        if (cmds.steering < 0) {
            turn_left.fillAmount = -cmds.steering;
            turn_right.fillAmount = 0;
        }
        else {
            turn_left.fillAmount = 0;
            turn_right.fillAmount = cmds.steering;
        }
        if (cmds.acceleration < 0) {
            accel_bottom.fillAmount = -cmds.acceleration;
            accel_top.fillAmount = 0;
        }
        else {
            accel_bottom.fillAmount = 0;
            accel_top.fillAmount = cmds.acceleration;
        }
    }
}

