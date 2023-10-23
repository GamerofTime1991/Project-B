using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDelete : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //This deletes the obstacle after a certain distance to lower computer resources
        if (transform.position.z < -85)
        {
            Destroy(gameObject);
        }
    }
}
