using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private int _dmg;
    [SerializeField] private float _bulletLife;

    private void Update()
    {
        
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        Destroy(gameObject, _bulletLife);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.TryGetComponent<LifeController>(out var enemy))
        {
            enemy.RemoveHp(_dmg);
            Destroy(gameObject);
        }
    }
}
