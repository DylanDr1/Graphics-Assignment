using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{

    [SerializeField] float speed;

    [SerializeField] Transform start, end;

    [SerializeField] float changeDirection;


     Transform target, origin;
     float journeyStartTime;
     float journeyDistance;
     bool isPaused;

    void Start()
    {
        origin = start;
        target = end;
        InitializeJourney();
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    private void InitializeJourney()
    {
        journeyStartTime = Time.time;
        journeyDistance = Vector3.Distance(origin.position, target.position);
        isPaused = false;
    }

    private void HandleMovement()
    {
        if (!isPaused)
        {
            if (Vector3.Distance(transform.position, target.position) > 0.01f)
            {
                float distanceTraveled = (Time.time - journeyStartTime) * speed;
                float journeyFraction = distanceTraveled / journeyDistance;

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
        origin = (origin == end) ? start : end;
        target = (target == start) ? end : start;
        InitializeJourney();
    }

    private IEnumerator PauseBeforeDirectionChange()
    {
        yield return new WaitForSeconds(changeDirection);
        SwitchDirection();
        isPaused = false;
    }
}