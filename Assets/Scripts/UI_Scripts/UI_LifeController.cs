using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_LifeController : MonoBehaviour
{

    [SerializeField] private Image _lifebarFillable;
    [SerializeField] private TextMeshProUGUI _lifeText;
    [SerializeField] private Gradient _lifeGradient;

    public void UpdateLifebar(int _hp, int _maxHp)
    {
        float _percentageLife = (float)_hp / 100;
        _lifebarFillable.fillAmount= _percentageLife;
        _lifeText.text= _hp + "/" + _maxHp;
        _lifebarFillable.color = _lifeGradient.Evaluate(_percentageLife);
    }
}
