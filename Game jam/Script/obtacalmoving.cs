using UnityEngine;

public class obtacalmoving : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _xBound;

    private void Update()
    {
        this.transform.position -= Vector3.up * _speed * Time.deltaTime;

        if (this.transform.position.x < _xBound)
        {
            Destroy(this.gameObject);
        }
    }
}
