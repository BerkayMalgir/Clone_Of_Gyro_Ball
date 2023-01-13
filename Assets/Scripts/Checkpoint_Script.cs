using UnityEngine;
using Unity.Mathematics;
public class Checkpoint_Script : MonoBehaviour
{
    
    public Transform character;
    
    private Rigidbody _rb;
    private float3 _checkpointPosition;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
        Spawn();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            UpdateCheckpointPosition(other.transform.position);
        }
       // if (other.gameObject.CompareTag("Kill"))
       // {
       //     character.position = _checkpointPosition;
      //  }
    }
    private void UpdateCheckpointPosition(float3 position)
    {
        _checkpointPosition = position;
    }
    private void Spawn()
    {
        if (!(character.transform.position.y < -10f)) return;
        Respawn();
    }

    private void Respawn()
    {
        _rb.velocity = Vector3.zero;
        _rb.angularVelocity =Vector3.zero;
        _rb.Sleep();
        character.position = _checkpointPosition;
    }
}

