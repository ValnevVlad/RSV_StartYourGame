using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay
{
    public class CameraMovement : MonoBehaviour
    {
        [SerializeField] private Camera camera;
        [SerializeField] private Bounds cameraBounds;
        private bool dragging = false;
        private Vector3 _prevPosition;

        private void CheckMouseDown()   
        {
            if (!Input.GetMouseButtonDown(0)) return;
            var ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray)) return;
            if (EventSystem.current.IsPointerOverGameObject(0)) return;
            _prevPosition = camera.ScreenToWorldPoint(Input.mousePosition);
            dragging = true;
        }

        private void Update()
        {
            CheckMouseDown();
            CheckMovement();
            CheckMouseUp();
        }

        private void CheckMovement()
        {
            if (!Input.GetMouseButton(0)) return;
            if (!dragging) return;
            var position = camera.ScreenToWorldPoint(Input.mousePosition);
            var newCameraPosition = ProcessCameraMovement(position, _prevPosition, camera.transform.position);
            camera.transform.position = cameraBounds.ClosestPoint(newCameraPosition);
            _prevPosition = camera.ScreenToWorldPoint(Input.mousePosition);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentMousePos">Позиция курсора(текущая), спроецированная в игровое поле</param>
        /// <param name="prevMousePos">Позиция курсора(предыдущая), спроецированная в игровое поле</param>
        /// <param name="currentCameraPos">Текущие координаты камеры</param>
        /// <returns>Новую позицию камеры</returns>
        public static Vector3 ProcessCameraMovement(Vector3 currentMousePos, Vector3 prevMousePos, Vector3 currentCameraPos)
        {
            //TASK - переделать функцию
            var delta = prevMousePos - currentMousePos;
            return currentCameraPos + delta;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireCube(cameraBounds.center, cameraBounds.extents * 2);
        }

        private void CheckMouseUp()
        {
            if (!Input.GetMouseButtonUp(0)) return;
            dragging = false;
        }
    }
}