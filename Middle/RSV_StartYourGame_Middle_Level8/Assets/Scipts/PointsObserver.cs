using UnityEngine;

public class PointsObserver : MonoBehaviour
{
    [SerializeField] private Transform[] _observerPoints;
    [SerializeField] private float _lookDelay;

    [SerializeField] private GameObject _fieldOfView;
    [SerializeField] private LayerMask _obstacleMask;
    [SerializeField] private LayerMask _playerMask;

    private float _timer = 0f;
    private int _currentObservablePointIndex;

    private void Awake()
    {
        _timer = _lookDelay;
    }

    private void Update()
    {
        LookAtTimerTick();
        LookAtPoint();
    }

    private void LookAtPoint()
    {
        Vector3 distanceToPoint = _observerPoints[_currentObservablePointIndex].transform.position - transform.position;
        Vector3 directionPoint = distanceToPoint.normalized;

        _fieldOfView.SetActive(Physics.Raycast(transform.position, directionPoint, distanceToPoint.magnitude,
            _obstacleMask) == false);
        transform.forward = new Vector3(directionPoint.x, 0f, directionPoint.z);

        if (Physics.Raycast(transform.position, directionPoint, out RaycastHit hit, distanceToPoint.magnitude, _playerMask))
        {
            hit.collider.GetComponent<Player>().Kill();
        }
        
    }

    private void LookAtTimerTick()
    {
        _timer -= Time.deltaTime;

        if (_timer <= 0)
        {
            int nextPoint = _currentObservablePointIndex + 1;

            if (nextPoint >= _observerPoints.Length)
            {
                nextPoint = 0;
            }

            _currentObservablePointIndex = nextPoint;
            _timer = _lookDelay;
        }
    }
}
