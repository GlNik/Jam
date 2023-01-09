using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrictionAnimated : MonoBehaviour
{
    [SerializeField] PhysicMaterial _defaultFriction;
    [SerializeField] PhysicMaterial _zeroFriction;

    [SerializeField] private Collider[] _leftLegCollider;
    [SerializeField] private Collider[] _rightLegCollider;

    public void SetLeftFriction()
    {
        for (int i = 0; i < _leftLegCollider.Length; i++)
        {
            _leftLegCollider[i].material = _defaultFriction;
            _rightLegCollider[i].material = _zeroFriction;

        }
    }

    public void SetRightFriction()
    {
        for (int i = 0; i < _leftLegCollider.Length; i++)
        {
            _leftLegCollider[i].material = _zeroFriction;
            _rightLegCollider[i].material = _defaultFriction;

        }
    }
}
