using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    #region Self Veriables

    #region Private Veriables

    [SerializeField] private float speed = 0;
    private float _movementX;
    private float _movementY;
    private Rigidbody _rigidbody;

    #endregion

    #endregion

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 movement = new Vector3(_movementX, 0.0F, _movementY);
        _rigidbody.AddForce(movement*speed);
    }

  
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        _movementX = movementVector.x;
        _movementY = movementVector.y;
    }
}
