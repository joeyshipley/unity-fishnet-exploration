using FishNet.Object;
using UnityEngine;

public class PlayerMovementRB : NetworkBehaviour
{
    Rigidbody _rigidbody;
    public float _speed = 5f;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(!IsOwner) return;
        
        var input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _rigidbody.MovePosition(transform.position + input * (Time.deltaTime * _speed));
    }
}
