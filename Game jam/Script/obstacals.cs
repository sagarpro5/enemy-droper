using UnityEngine;

public class obstacals : MonoBehaviour
{
    public GameObject o1;
    public GameObject o2;
    public GameObject o3;
    public GameObject o4;
    public GameObject o5;
    public GameObject o6;
    public GameObject o7;
    public GameObject o8;
    public GameObject o9;
    public Transform spawn;
    float _yClamp = 10;
    int counter;


    int random;


    private void Update()
    {
        counter++;
        if(counter == 30)
        {

            random = Random.Range(1, 9);
            if (random == 1)
            {
                SpawnObject(o1);
            }
            if (random == 2)
            {
                SpawnObject(o2);
            }
            if (random == 3)
            {
                SpawnObject(o3);
            }
            if (random == 4)
            {
                SpawnObject(o4);
            }
            if (random == 5)
            {
                SpawnObject(o5);
            }
            if (random == 6)
            {
                SpawnObject(o6);
            }
            if (random == 7)
            {
                SpawnObject(o7);
            }
            if (random == 8)
            {
                SpawnObject(o8);
            }
            if (random == 9)
            {
                SpawnObject(o9);
            }
        }



    }



    private void SpawnObject(GameObject _prefab)
    {
        float offsetY = Random.Range(-_yClamp, _yClamp);

        Vector2 pos = new Vector2(this.transform.position.x + offsetY, this.transform.position.y);

        Instantiate(_prefab, pos, Quaternion.identity, this.transform);
        counter = 0;
    }




}
