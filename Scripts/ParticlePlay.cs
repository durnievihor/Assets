using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlay : MonoBehaviour
{

    public ParticleSystem ParSys;
    public bool played = false;

    void Awake()
    {
        ParSys = GetComponent<ParticleSystem>();

    }

    public void OnTriggerEnter(Collider other)
    {
        ParSys.Play();
        played = true;
    }

    public void Update()
    {
        if (ParSys && played && !ParSys.IsAlive())
        {             
            Destroy(gameObject);
        }
    }
}
