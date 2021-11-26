﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script to allow for smooth camera movement.
public class SmoothCamera : MonoBehaviour {
    public Transform lookAt;

    private readonly bool _smooth = true;
    public float smoothSpeed = 5.5f;//0.125f;
    private readonly Vector3 _offset = new Vector3(0, 17.5f, -7.5f);

    private void LateUpdate() {
        Vector3 desiredPosition = lookAt.transform.position + _offset;

        if (_smooth) {
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        }
        else {
            transform.position = desiredPosition;
        }
    }

}

