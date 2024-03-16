using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject explosion;
    private float speed = 0.0f;
    private float ySpeed = 0.0f;
    private float mass = 10.0f;
    private float force = 2.0f;
    private float drag = 1.0f;
    private float gravity = -9.8f;
    private float gAcc;
    private float acceleration;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "tank")
        {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        acceleration = force / mass;
        speed += acceleration * 1.0f;
        gAcc = gravity / mass;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        speed *= (1 - Time.deltaTime * drag);
        ySpeed += gAcc * Time.deltaTime;
        this.transform.Translate(0, ySpeed, speed);
    }
}
