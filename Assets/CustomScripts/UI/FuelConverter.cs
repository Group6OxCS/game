﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelConverter : MonoBehaviour {
    public float minAngle = -76.7f, maxAngle = -193f;

    public void ShowFuel(float fuel) {
        float angle = Mathf.Lerp (minAngle, maxAngle, Mathf.InverseLerp (0, 1, fuel));
        transform.eulerAngles = new Vector3 (0, 0, angle);
    }
}
