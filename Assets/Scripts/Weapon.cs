using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour, Throwable
{
    [Header("Shot")]
    [Tooltip("Button that triggers the shot")]
    [SerializeField]
    private KeyCode shot;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(shot)){
            Shot();
        }
        Debug.DrawLine(transform.position, GetDirection(), Color.red);
    }

    Vector3 GetDirection() {
        Vector3 direction = Input.mousePosition;
        direction.z = Camera.main.nearClipPlane+12;
        return Camera.main.ScreenToWorldPoint(direction);
    }

    void Shot() {
        Throw(GetDirection());
    }

    public void Throw(Vector3 direction) {
        Debug.DrawLine(transform.position, direction, Color.black, 3);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, direction, out hit))
        {
            Debug.Log("Did Hit");
        }
    }
}
