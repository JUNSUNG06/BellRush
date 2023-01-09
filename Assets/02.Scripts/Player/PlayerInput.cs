using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerInput : MonoBehaviour
{
    public Action jumpAction;
    public Action slideAction;
    public Action objectAction;

    public void JumpAction()
    {
        jumpAction();
    }

    public void SlideAction()
    {
        slideAction();
    }

    public void ObjectAction()
    {
        objectAction();
    }
}
