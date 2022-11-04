using UnityEngine;

namespace Parallax
{
    public class ParallaxView : MonoBehaviour
    {
        [SerializeField] private float movementCoefficient;
        
        public void MoveParallax(Vector3 deltaMove)
        {
            transform.position = CalculatePositionParallax(transform.position, deltaMove, movementCoefficient);
        }

        /// <summary>
        /// Вычисляет позицию объекта в системе параллакса 
        /// </summary>
        /// <param name="currentPos">текущая позиция объекта</param>
        /// <param name="deltaMove">смещение камера</param>
        /// <param name="alpha">коэффициент параллакса</param>
        /// <returns>новая позиция объекта после указанного смещения камеры</returns>
        public static Vector3 CalculatePositionParallax(Vector3 currentPos, Vector3 deltaMove, float alpha)
        {
            //Напиши код, который возвращает позицию с корректировкой после смещения
            //currentPos.x += deltaMove.x * alpha;
            //return currentPos;

            return currentPos + (deltaMove * alpha);
        }
    }
}