using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateMove : MonoBehaviour
{
    public float speed = 1.0f;

    void Update()
    {
        this.transform.Translate(0, 0, Time.deltaTime * speed);
    }
}
