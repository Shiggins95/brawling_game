using System;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private PlayerMovement _pm;
    [SerializeField] private bool _followY;
    [SerializeField] private bool _followX;

    private void Update()
    {
        var newPosition = _pm.transform.position;
        if (!_followX)
        {
            newPosition.x = 0;
        }

        if (!_followY)
        {
            newPosition.y = 0;
        }

        transform.position = newPosition;
    }
}