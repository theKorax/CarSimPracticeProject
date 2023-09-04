using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    Vector3 offset = new Vector3(0, 4, -6);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // LateUpdate updates after the Update method
    // the vehicle runs Update, then the camera runs LateUpdate so the followplayer effect is smoother
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
