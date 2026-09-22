using TreeEditor;
using Unity.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject mob;

    public int instant;

    void Start()
    {


        for (int i = 0; i < 101; i++)
        {
            for (int j = 0; j < 101; j++)
            {
                float perlinY = Mathf.PerlinNoise(i * 0.05f, j * 0.05f) * 3;
                Instantiate(mob, new Vector3(j, perlinY, i), Quaternion.identity);

            }

        }

        for (int w = 0; w < 2; w++)
        {
            int li1 = 0;
            int li2 = 0;
            for (int t = 0; t < 2; t++)
            {

                for (int h = 0; h < 4; h++)
                {


                    for (int l = 0; l < 102; l++)
                    {
                        Instantiate(mob, new Vector3(l, 1.5f + h, 0 + li1), Quaternion.identity);

                    }
                }
                li1 += 101;

            }

            for (int t = 0; t < 2; t++)
            {
                for (int h = 0; h < 4; h++)
                {
                    for (int l = 0; l < 101; l++)
                    {
                        Instantiate(mob, new Vector3(0 + li2, 1.5f + h, l), Quaternion.identity);
                    }
                }
                li2 += 100;
            }

        }
    }


    void Update()
    {

    }
}
