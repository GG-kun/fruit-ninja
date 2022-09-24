using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Playable
{
    public override void Selected()
    {
        FindObjectOfType<Life>().Dead();
        base.Selected();
    }
}
