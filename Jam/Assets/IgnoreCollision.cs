using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    [SerializeField] private Collider[] _ignoreColliders;

    private void Awake()
    {
        for (int i = 0; i < _ignoreColliders.Length; i++)
        {
            for (int k = 0; k < _ignoreColliders.Length; k++)
            {
                Physics.IgnoreCollision(_ignoreColliders[i], _ignoreColliders[k], true);
            }
        }
    }
}
