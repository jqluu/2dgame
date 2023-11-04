using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;


public class AttackScript : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    [SerializeField]
    AudioSource source;
    [SerializeField]
    AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);

            source.PlayOneShot(clip);
        }
    }
}
