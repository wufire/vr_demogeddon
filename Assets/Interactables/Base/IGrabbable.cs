using UnityEngine;

public interface IGrabbable
{
    Rigidbody Rigidbody
    {
        get;
    }
    Joint CreateGrabJoint();
    Transform Transform
    {
        get;
    }
    bool MoveToGrabberWhenGrabbed
    {
        get;
    }
    Throw ConnectedHand
    {
        get; set;
    }
    float BreakForce
    {
        get;
    }
}
