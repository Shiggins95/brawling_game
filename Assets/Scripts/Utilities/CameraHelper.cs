using UnityEngine;

public static class CameraHelper
{
        public static Vector2 ConvertWorldToCamera(Vector2 currentPosition)
        {
            var camera = Camera.main;
            if (camera is not null)
            {
                var viewportPosition = camera.WorldToViewportPoint(currentPosition);
                return viewportPosition;
            }

            return new Vector2(0, 0);
        }

        public static Vector2 ConvertViewportPointToWorld(Vector2 newPosition)
        {
            var camera = Camera.main;
            if (camera is not null)
            {
                var viewportPosition = camera.ViewportToWorldPoint(newPosition);
                return viewportPosition;
            }

            return new Vector2(0, 0);
        }
}