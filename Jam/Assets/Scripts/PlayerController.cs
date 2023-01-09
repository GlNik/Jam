using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float _forceSpeed = 1f;
    [SerializeField] private float _forceTimeout = 1f;

    private Rigidbody _rigidBody;
    private float _forceTime;

    void Start() {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.W)
            || Input.GetKeyDown(KeyCode.A)
            || Input.GetKeyDown(KeyCode.S)
            || Input.GetKeyDown(KeyCode.D)) {

            if (Time.time > _forceTime) {
                Force();

                _forceTime = Time.time + _forceTimeout;
            }
        }
    }

    private void Force() {
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");

        Vector3 moveDirection = new Vector3(h, 0, v) * Random.Range(_forceSpeed - 10, _forceSpeed);

        _rigidBody.AddForce(moveDirection, ForceMode.VelocityChange);
    }
}
