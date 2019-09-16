using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform launchPosition;

    void fireBullet()
    {
        // 1 - Creates instance of bullet prefab
        GameObject bullet = Instantiate(bulletPrefab) as GameObject;
        // 2 - Sets the bullet's launch position to the gun
        bullet.transform.position = launchPosition.position;
        // 3 - Sets the speed and direction the bullet travels relative to the faced direction
        bullet.GetComponent<Rigidbody>().velocity =
        transform.parent.forward * 100;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Checks if mouse button is down and invoking fire bullet. If not, it fires a bullet.
        if (Input.GetMouseButtonDown(0))
        {
            if (!IsInvoking("fireBullet"))
            {
                InvokeRepeating("fireBullet", 0f, 0.1f);
            }
        }

        // Cancels invoking of fire bullet when mouse button is released.
        if (Input.GetMouseButtonUp(0))
        {
            CancelInvoke("fireBullet");
        }
    }
}