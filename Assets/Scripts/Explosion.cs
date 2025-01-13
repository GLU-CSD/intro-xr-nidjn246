using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Explosion : MonoBehaviour
{
    public float explosionForce = 500f;      // Kracht van de explosie
    public float explosionRadius = 5f;       // Radius van de explosie
    public float explosionDamage = 20f;      // Damage van de explosie

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // Zorg dat vijanden de tag "Enemy" hebben
        {
            Explode();
            Destroy(gameObject); // Verwijder het object na de explosie
        }
    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider nearbyObject in colliders)
        {
            NavMeshAgent agent = nearbyObject.GetComponent<NavMeshAgent>();
            if (agent != null)
            {
                //agent.enabled = false;
            }

            Health healthScript = nearbyObject.GetComponent<Health>();
            if (healthScript != null)
            {
                healthScript.TakeDamage(explosionDamage);
            }

            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }
        }
    }

}

