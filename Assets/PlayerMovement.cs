using FishNet.Object;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour
{
    [SerializeField] private float _moveRate = 7.5f;
    private CharacterController _characterController;
    private bool _characterControllerInitialized = false;
    
    public override void OnStartNetwork()
    {
        _characterController = GetComponent<CharacterController>();
        _characterControllerInitialized = true;
        
        if(!IsOwner) // NOTE: this is blocking editor player from being able to control movement. Build and run that way.
            _characterController.enabled = false;
        
        base.OnStartNetwork();
    }

    private void FixedUpdate()
    {
        if(!IsOwner || !_characterControllerInitialized) return;
        
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        
        var offset = new Vector3(horizontal, Physics.gravity.y, vertical) * (_moveRate * Time.deltaTime);
        _characterController.Move(offset);
    }
}
