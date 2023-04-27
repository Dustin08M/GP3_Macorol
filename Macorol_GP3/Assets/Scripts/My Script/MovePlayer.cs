using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private int _moveSpeed = 10;

    float PosX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PosX = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * _moveSpeed * Time.deltaTime * PosX);
    }
}
