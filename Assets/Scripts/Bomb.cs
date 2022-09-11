using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Playable
{
    public override void HittedByPlayer()
    {
        FindObjectOfType<Life>().Dead();
    }
}
