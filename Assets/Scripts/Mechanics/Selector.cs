using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Selector : MonoBehaviour, Throwable
{
    [Header("Shot")]
    [Tooltip("Button that triggers the shot")]
    [SerializeField]
    private KeyCode shot; 
    [SerializeField]
    private float distance = 50;
    private LineRenderer line;

    void Start() {
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        line.SetPosition(0, transform.position);
        if(Input.GetKeyDown(shot)){
            Shot();
        } else {
            line.SetPosition(1,transform.position+GetDirection()*distance);
        }
    }

    Vector3 GetDirection() {
        return transform.forward;
    }

    void Shot() {
        Throw(GetDirection());
    }

    RaycastHit hit;
    Selectable selectable;
    public void Throw(Vector3 direction) {
        if (Physics.Raycast(transform.position, direction, out hit))
        {
            line.SetPosition(1,hit.point);
            selectable = hit.collider.gameObject.GetComponent<Selectable>();
            if(selectable!=null) {
                selectable.Selected();
            }
        }
    }
}
