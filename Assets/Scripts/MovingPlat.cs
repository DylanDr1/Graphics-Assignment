using System.Collections;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    [SerializeField] private PlatformData platformData;

    private Transform target, origin;
    private float journeyStartTime;
    private float journeyDistance;
    private bool isPaused;

    void Start()
    {
        origin = platformData.start;
        target = platformData.end;
        InitializeJourney();
    }

    void FixedUpdate()
    {

        HandleMovementAndSwitch();
    }

    private void InitializeJourney()
    {
        journeyStartTime = Time.time;
        journeyDistance = Vector3.Distance(origin.position, target.position);
        isPaused = false;
    }

    private void HandleMovementAndSwitch()
    {

        if (!isPaused)
        {

            float distanceTraveled = (Time.time - journeyStartTime) * platformData.speed;
            float journeyFraction = distanceTraveled / journeyDistance;


            if (journeyFraction < 1f)
            {
                transform.position = Vector3.Lerp(origin.position, target.position, journeyFraction);
            }
            else
            {

                isPaused = true;
                StartCoroutine(PauseBeforeDirectionChange());
            }
        }
    }

    private void SwitchDirection()
    {

        (origin, target) = (target, origin);
        InitializeJourney();
    }

    private IEnumerator PauseBeforeDirectionChange()
    {
        yield return new WaitForSeconds(platformData.changeDirection);
        SwitchDirection();
        isPaused = false;
    }
}