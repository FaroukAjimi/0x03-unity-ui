using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    void Start()
    {
        player = GameObject.Find("Player");
        
    }
    // Update is called once per frame
    void LateUpdate()
    {
        offset.x = 4;
        offset.y = 15;
        this.transform.position = player.transform.position + offset;
    }
}
