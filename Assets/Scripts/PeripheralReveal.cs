using UnityEngine;

public class JigglypuffPeripheralReveal : MonoBehaviour
{
    public Transform playerCamera;
    public GameObject jigglypuff;

    void Update()
    {
        Vector3 directionToPokemon =
            (jigglypuff.transform.position
            - playerCamera.position).normalized;

        float dot = Vector3.Dot(
            playerCamera.forward,
            directionToPokemon
        );

        if (dot > 0.3f && dot < 0.8f)
        {
            jigglypuff.SetActive(true);
        }
        else
        {
            jigglypuff.SetActive(false);
        }
    }
}