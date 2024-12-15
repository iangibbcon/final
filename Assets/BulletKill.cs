using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//small class to stop shooting from spamming the hierarchy

public class BulletKill : MonoBehaviour
{
    public float lifeTime = 3f;

    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}