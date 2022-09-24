using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
[RequireComponent(typeof(BoxCollider))]
public class Button3D : MonoBehaviour, Selectable
{
    Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
    }

    public void Selected() {
        button.onClick.Invoke();
    }
}
