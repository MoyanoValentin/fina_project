using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviourScript : MonoBehaviour
{

    [SerializeField]//para q se vea en el unity
    private float speedZ = 20f;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject)
        {
            Destroy(gameObject);
        }

    }


    void Update()
    {

        transform.Translate(0, 0, speedZ *Time.deltaTime);
       // destroyBall();
    }

    public void destroyBall()
    {
        if (transform.position.z < -5 || transform.position.z > 6)
        {
            Destroy(transform.gameObject);
        }
    }
}
