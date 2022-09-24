using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(Rigidbody))]
public abstract class Playable : MonoBehaviour, Throwable, ISpawnable, Selectable
{
    [Header("Positions")]
    [Tooltip("List of positions where playable can spawn")]
    [SerializeField]
    // Positions where playable can spawn
    private List<Vector3> positions;

    private Vector3 GetPosition() {
        return positions[Random.Range(0,positions.Count)];
    }

    public void Spawn() {
        Instantiate(
            gameObject, 
            GetPosition(), 
            gameObject.transform.rotation
        );
    }

    [Header("Player")]
    [Tooltip("Tag")]
    [SerializeField]
    // Player Tag which will dictate throw direction 
    private string playerTag = "Player";

    [Header("Force")]
    [Tooltip("Force with which playable will be thrown")]
    [SerializeField]
    // Force with which playable will be thrown
    private float force;

    private Rigidbody rigidbody;

    private Vector3 GetDirection() {
        return transform.forward + Vector3.up;
    }

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        transform.LookAt(GameObject.FindGameObjectWithTag(playerTag).transform);
        Throw(GetDirection().normalized);
    }

    public void Throw(Vector3 direction) {
        rigidbody.AddForce(
            direction * force
        );
    }

    [Header("Destroyer")]
    [Tooltip("Tag of playable destroyer")]
    [SerializeField]
    private string destroyerTag = "Destroyer";
    
    public void Destroyed() {
        Destroy(gameObject);
    }

    public virtual void Fallen() {
        Destroyed();
    }

    public virtual void Selected() {
        Destroyed();
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == destroyerTag) {
            Fallen();
        }
    }
}
