using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject mob;

    public KeyCode sp = KeyCode.M;

    public int instant;

    void Start()
    {
        instant = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(sp))
        {
            //Instantiate(mob, new Vector3(5, 1.5f, instant), Quaternion.identity);
            // instant += 1;
           /*Instantiate(mob, new Vector3(0, 0, 0), Quaternion.identity);
            Instantiate(mob, new Vector3(1, 0, 0), Quaternion.identity);
            Instantiate(mob, new Vector3(2, 0, 0), Quaternion.identity);*/

            for(int i = 0; i < 100; i++)
            {
                Instantiate(mob, new Vector3(15, 15, 15)* i, Quaternion.identity);
            }
        }
    }
}
