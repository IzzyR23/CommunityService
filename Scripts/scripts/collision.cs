using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public Rigidbody _rigidbody;

    [SerializeField] private float _movementForce = 10f;

 void Awake() => _rigidbody = GetComponent<Rigidbody>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        _rigidbody.AddForce(_movementForce * Vector3.forward);

        if(Input.GetKey(KeyCode.S))
        _rigidbody.AddForce(_movementForce * Vector3.back);

        if(Input.GetKey(KeyCode.D))
        _rigidbody.AddForce(_movementForce * Vector3.right);

        if(Input.GetKey(KeyCode.A))
        _rigidbody.AddForce(_movementForce *Vector3.left);
    }
}
