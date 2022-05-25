using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class Player1Movement : MonoBehaviour
{
    private float speed = 10;

    void Update()
    {
        float inputY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(0, speed * inputY);

        movement *= Time.deltaTime;
        transform.Translate(movement);
    }

}
