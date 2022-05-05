using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Helpers 
{
    public static Vector3 ScreenToWorldPosition(this Vector2 screenPos, Camera targetCam, float targetPositionY)
    {
        var ray = targetCam.ScreenPointToRay(screenPos);
        var directionYZero = ray.direction;
        directionYZero.y = 0;
        var sinAlpha = Mathf.Sin(Vector3.Angle(ray.direction, directionYZero) * Mathf.Deg2Rad);
        var result = ray.origin + ray.direction.normalized * (ray.origin.y - targetPositionY) / sinAlpha;
        Debug.Log("World pos: " + result);
        return result;
    }
}
