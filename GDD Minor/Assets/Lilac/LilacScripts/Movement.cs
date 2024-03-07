using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public int z = 3;
    public int x = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        this.Move();
    }

    void Move() {
        if(Input.GetKey("w")){
            this.MoveForward();
        }

        if(Input.GetKey("a")){ 
            this.MoveLeft();
        }

        if(Input.GetKey("s")){
            this.MoveBackward();
        }

        if(Input.GetKey("d")){
            this.MoveRight();
        }
    }

    void MoveForward() {
        transform.position += new Vector3(0, 0, z * Time.deltaTime);
    }

    void MoveLeft() {
        transform.position += new Vector3(x * -1 * Time.deltaTime, 0,0);
    }

    void MoveBackward() {
        transform.position += new Vector3(0, 0, z * -1 * Time.deltaTime);
    }

    void MoveRight() {
        transform.position += new Vector3(x * Time.deltaTime, 0,0);
    }
}
