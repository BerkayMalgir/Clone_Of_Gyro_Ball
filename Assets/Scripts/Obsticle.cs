using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    public List<Transform> waypoints;
    private int _waypointIndex;
    private float _range;

    private void Start()
    {
        _waypointIndex = 0;
        _range = 1.0f;
        
    }

    private void Update()
    {
        Move();          
    }

    private void Move()
    {
        transform.LookAt(waypoints[_waypointIndex]);
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        if (!(Vector3.Distance(transform.position, waypoints[_waypointIndex].position) < _range)) return;
        _waypointIndex++;
        
        if (_waypointIndex >= waypoints.Count)
        {
            _waypointIndex = 0;
        }
    }
}