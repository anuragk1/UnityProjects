﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAgentFollower : MonoBehaviour
{
    public Transform BallAgentTransform;

    public Vector3 _cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - BallAgentTransform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = BallAgentTransform.position + _cameraOffset;
    }
}
