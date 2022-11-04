using UnityEngine;

namespace Gameplay.Map
{
    public class MapCoordinates : MonoBehaviour
    {
        [SerializeField] private float deltaX;
        [SerializeField] private float deltaY;
        [SerializeField] private Transform startPoint;
        [SerializeField] private Transform collectPoint;


        public Vector3 CollectionPoint => collectPoint.position;
        public Vector3 GetPointPos(Vector2Int point)
        {
            return GetPointPosition(point, deltaX, deltaY, startPoint.position);
        }

        public static Vector3 GetPointPosition(Vector2Int point, float deltaX, float deltaY, Vector3 startPoint)
        {
            return new Vector3(startPoint.x + point.x * deltaX, startPoint.y + point.y * deltaY, startPoint.z);
        }
    }
}