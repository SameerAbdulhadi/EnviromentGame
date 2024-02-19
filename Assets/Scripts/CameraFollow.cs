using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public float followSpeed = 2f;
    public Transform Target;

    // Update is called once per frame
    void Update()
    {
        Vector3 NewPos  = new Vector3(Target.position.x,Target.position.y,-10f);
        transform.position = Vector3.Slerp(transform.position, NewPos, followSpeed*Time.deltaTime);
    }
}
