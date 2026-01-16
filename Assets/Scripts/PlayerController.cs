using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Rigidbody _rb;

    private void Awake()
    {
        _rb=GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float _hMove = Input.GetAxis("Horizontal");
        float _vMove = Input.GetAxis("Vertical");

        Vector3 _direction = new Vector3(_hMove, 0, _vMove);
        _direction = _direction.normalized;
        Vector3 _newdir = _rb.position + _direction * _speed * Time.fixedDeltaTime;

        _rb.MovePosition(_newdir);
    }
}
