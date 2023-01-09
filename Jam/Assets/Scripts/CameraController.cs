using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    [SerializeField] private Transform _targetFollow;
    [SerializeField] private float _moveSpeed;

    // Update is called once per frame
    void LateUpdate() {
        Vector3 targetFollow = new Vector3(
            _targetFollow.position.x,
            transform.position.y,
            _targetFollow.position.z - 7f);
        transform.position = Vector3.Lerp(transform.position, targetFollow, Time.deltaTime * _moveSpeed);
    }
}
