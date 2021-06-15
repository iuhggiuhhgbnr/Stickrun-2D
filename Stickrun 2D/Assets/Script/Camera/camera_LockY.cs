﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class camera_LockY : CinemachineExtension
{
    public float m_ZPosition = 10;

    protected override void PostPipelineStageCallback( CinemachineVirtualCameraBase vcam,CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            pos.y = m_ZPosition;
            state.RawPosition = pos;
        }
    }
}
