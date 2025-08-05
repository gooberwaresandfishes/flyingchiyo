using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic.isAlive) return;
        
        transform.position += Vector3.left * (5 + Time.timeSinceLevelLoad /15) * Time.deltaTime;
    }

    void OnBecameInvisible()
    {
        if (transform.position.x < 0)
        {
            Destroy(gameObject);
        }
    }
}
