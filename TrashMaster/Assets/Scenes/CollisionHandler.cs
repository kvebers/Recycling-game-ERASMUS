using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public string destroyObjectName = "TrashbinYellow";
    public string collisionObjectName = "Plane";
    public AudioClip destroySound;


    private bool lifePointsDecreased = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (lifePointsDecreased)
            return;

        GameObject collidedObject = collision.gameObject;

        if (collidedObject.CompareTag(destroyObjectName))
        {
            GameStateManager.Instance.IncreasePoints(1);
            AudioSource.PlayClipAtPoint(destroySound, transform.position);
            Destroy(this.gameObject);
        }
        else if (collidedObject.CompareTag(collisionObjectName))
        {
            GameStateManager.Instance.DecLifePoints(1);
            lifePointsDecreased = true;
            AudioSource.PlayClipAtPoint(destroySound, transform.position);
            Destroy(this.gameObject);
        }

    }
}