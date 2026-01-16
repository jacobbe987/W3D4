using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooterController : MonoBehaviour
{
    [SerializeField] private float _fireRate;
    private float _lastShot;
    [SerializeField] private GameObject _bulletGO;
    [SerializeField] private Transform _shootingPoint;

    private bool CanShoot()
    {
        return Time.time - _lastShot >= _fireRate;
    }

    
    private void Shoot()
    {
        if (Input.GetMouseButton(0))
        {
            Instantiate(_bulletGO, _shootingPoint.position, Quaternion.identity);
        }
    }

    private void Update()
    {
        Shoot();
    }
}
