using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShipEngine : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

   
    public Vector3 Thrust()
    {
        return Vector3.forward * _moveSpeed * Time.deltaTime;
    }
}
