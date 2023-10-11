using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFire : MonoBehaviour
{
    public float fireRateIncrease = 2f;
    public float time = 15;

    private Player player;
    private float oldFireRate;

    private void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.name);
        if (other.gameObject.CompareTag("Tank"))
        {
            //teleport out of view
            transform.position = new Vector3(0, 100, 0);

            player = other.gameObject.GetComponent<Player>();
            oldFireRate = player.cooldown;

            StartCoroutine(ChangeFireRate());
        }
    }

    IEnumerator ChangeFireRate()
    {
        player.cooldown /= fireRateIncrease;
        yield return new WaitForSeconds(time);
        player.cooldown = oldFireRate;
        Destroy(gameObject);
    }
}
