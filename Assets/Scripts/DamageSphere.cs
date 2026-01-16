using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSphere : MonoBehaviour
{
    [SerializeField] private int _dmg;
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<LifeController>(out var player))
        {
            player.RemoveHp(_dmg);
        }

    }
}
