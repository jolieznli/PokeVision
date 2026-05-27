using UnityEngine;

public class DistanceReveal : MonoBehaviour
{
    public Transform player;
    public GameObject hiddenPokemon;
    public GameObject disguiseObject;

    public float revealDistance = 3f;

    void Update()
    {
        float dist = Vector3.Distance(
            player.position,
            transform.position
        );

        if (dist < revealDistance)
        {
            hiddenPokemon.SetActive(true);
            disguiseObject.SetActive(false);
        }
        else
        {
            hiddenPokemon.SetActive(false);
            disguiseObject.SetActive(true);
        }
    }
}