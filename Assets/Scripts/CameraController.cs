using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if ( transform.position.y >= 65)
        {
            pos = player.transform.position + distance;
        }

        
       
        if (transform.position.y < 65)
        {
            pos.y = 65;
            
        }
        transform.position = pos;
            
    }
}
