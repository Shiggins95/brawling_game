using System;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
        [SerializeField] private bool _wrapX;
        [SerializeField] private bool _wrapY;
        private bool _isWrappingX;
        private bool _isWrappingY;
        
        private void Update()
        {
                var currentPosition = transform.position;
                var viewportPoint = CameraHelper.ConvertWorldToCamera(currentPosition);
                var newPosition = currentPosition;
                if (_wrapX)
                {
                        if (!_isWrappingX && viewportPoint.x is < 0 or > 1)
                        {
                                _isWrappingX = true;
                                newPosition.x = -currentPosition.x;
                        }
                        else if (_isWrappingX && viewportPoint.x is >= 0 and <= 1)
                        {
                                _isWrappingX = false;
                        }
                }

                if (_wrapY)
                {
                        if (!_isWrappingY && viewportPoint.y is < 0 or > 1)
                        {
                                _isWrappingY = true;
                                newPosition.y = -currentPosition.y;
                        }
                        else if (_isWrappingY && viewportPoint.y is >= 0 and <= 1)
                        {
                                _isWrappingY = false;
                        }
                }

                transform.position = newPosition;
        }
}