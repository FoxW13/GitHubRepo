using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * Fox Weymouth
		 * 3D Game Prototype
		 * Assignment 5B
		 * This code controls the gun with raycast, having its damage, range, particle system, and hit force all ran when the shoot function is called.
		 */
public class ShootWithRaycasts : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera cam;
    public ParticleSystem muzzleFlash;
    public float hitForce = 10f;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1")) { Shoot(); }
    }
    void Shoot()
    {

        muzzleFlash.Play();

        RaycastHit hitInfo;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            Target target =
            hitInfo.transform.gameObject.GetComponent<Target>();

            if (target != null )
            {
                target.TakeDamage(damage);

                if(hitInfo.rigidbody != null)
                {
                    hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
                }
            }
        }
    }
}
