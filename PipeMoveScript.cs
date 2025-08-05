using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

        if (transform.position.y > 5)
        {
            Destroy(this.gameObject.transform.GetChild(0).gameObject);
        }
        else if (transform.position.y < -5)
        {
            Destroy(this.gameObject.transform.GetChild(1).gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic.isAlive) return;
        
        transform.position += Vector3.left * (5 + Time.timeSinceLevelLoad /15) * Time.deltaTime;

        if (transform.position.x < -30)
        {
            Destroy(gameObject);
        }
    }
}
