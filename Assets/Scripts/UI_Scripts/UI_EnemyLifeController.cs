using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_EnemyLifeController : MonoBehaviour
{

    [SerializeField] private Image _lifebarFillable;

    public void UpdateEnemyLifebar(int _hp, int _maxHp)
    {
        float _percentageLife = (float)_hp / 100;
        _lifebarFillable.fillAmount = _percentageLife;
    }

}
