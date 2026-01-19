using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooterController : MonoBehaviour
{
    [SerializeField] private float _fireRate;
    private float _timer;
    [SerializeField] private GameObject _bulletGO;
    [SerializeField] private Transform _shootingPoint;
    
    private void Shoot()
    {
        _timer += Time.time;
        if (Input.GetMouseButton(0))
        {
            Instantiate(_bulletGO, _shootingPoint.position, Quaternion.identity);
            _timer = 0f;
        }
    }

    private void Update()
    {
        Shoot();
    }
}
