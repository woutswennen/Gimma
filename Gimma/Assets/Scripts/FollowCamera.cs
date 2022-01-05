using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // this camera should be the characters position
    [SerializeField] GameObject thingToFollow;

    [SerializeField] float offset;

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3(offset,0,-1);
    }
}
