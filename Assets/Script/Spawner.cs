using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject mob;

    public KeyCode sp = KeyCode.E;

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
            Instantiate(mob, new Vector3(5, 1.5f, instant), Quaternion.identity);
            instant += 1;
        }
    }
}
