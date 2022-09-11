using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class Playable : MonoBehaviour, Throwable, Spawnable, Hittable
{
    [Header("Position")]
    [Tooltip("Minimum position where the object can spawn")]
    [SerializeField]
    // Minimum position where the object can spawn
    private Vector3 minPosition = Vector3.zero;
    [Tooltip("Maximum position where the object can spawn")]
    [SerializeField]
    // Maximum position where the object can spawn
    private Vector3 maxPosition = Vector3.one;

    public void Spawn() {
        Instantiate(
            gameObject, 
            Vector3Helper.RandomVector3(minPosition, maxPosition), 
            gameObject.transform.rotation
        );
    }

    [Header("Direction")]
    [Tooltip("Minimum direction in which the object will be thrown")]
    [SerializeField]
    // Minimum direction in which the object will be thrown
    private Vector3 minDirection = Vector3.up + (Vector3.left*0.2f);
    [Tooltip("Maximum direction in which the object will be thrown")]
    [SerializeField]
    // Maximum direction in which the object will be thrown
    private Vector3 maxDirection = Vector3.up + (Vector3.right*0.2f);

    [Header("Force")]
    [Tooltip("Force with which the object will be thrown")]
    [SerializeField]
    // Force with which the object will be thrown
    private float force;

    private Rigidbody rigidbody;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        Throw(Vector3Helper.RandomVector3(minDirection, maxDirection).normalized);
    }

    public void Throw(Vector3 direction) {
        rigidbody.AddForce(
            direction * force
        );
    }

    [Header("Hit")]
    [Tooltip("Tag of hittable objects destroyer")]
    [SerializeField]
    private string destroyerTag = "Destroyer";
    [Tooltip("Tag of player")]
    [SerializeField]
    private string playerTag = "Player";

    public virtual void Hitted() {
        Destroy(gameObject);
    }
    public abstract void HittedByPlayer();
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == destroyerTag) {
            Hitted();
        } else if(other.gameObject.tag == playerTag) {
            HittedByPlayer();
        }
    }
}
