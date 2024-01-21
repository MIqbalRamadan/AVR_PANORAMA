using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
public class movementcamera : MonoBehaviour
{

    public float Speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
            Vector2 TouchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate(-TouchDeltaPosition.x * Speed, -TouchDeltaPosition.y * Speed, 0);

            transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, -360f, 360f),
                Mathf.Clamp(transform.position.y, -360f, 360f),
                Mathf.Clamp(transform.position.z, -360f, 360f)
            );
        }
    }

}
