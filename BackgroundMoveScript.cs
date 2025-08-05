using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoveScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left / 6) * (5 + Time.timeSinceLevelLoad /15) * Time.deltaTime;

        if (transform.position.x < -16.3)
        {
            transform.SetPositionAndRotation(new Vector3(20.26F, transform.position.y, 0), transform.rotation);
        }
    }
}
