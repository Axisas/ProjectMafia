using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset = new Vector3(0, 0, -10f);

    private void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.transform.position + offset;
        }
    }
}
