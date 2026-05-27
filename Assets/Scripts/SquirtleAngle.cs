using UnityEngine;

public class SquirtleAngleReveal : MonoBehaviour
{
    public Transform playerCamera;
    public GameObject squirtle;

    public float upwardThreshold = 0.5f;
    public float revealDistance = 4f;

    void Update()
    {
        float dist = Vector3.Distance(
            playerCamera.position,
            squirtle.transform.position
        );

        bool lookingUp =
            playerCamera.forward.y > upwardThreshold;

        bool closeEnough =
            dist < revealDistance;

        if (lookingUp && closeEnough)
        {
            squirtle.SetActive(true);
        }
        else
        {
            squirtle.SetActive(false);
        }
    }
}