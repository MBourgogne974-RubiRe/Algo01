using TreeEditor;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cube;

    public int bon = Random.Range(0,10);

    public int instant;

    void Start()
    {

        bon = Random.Range(0, 10);
        if (bon > 0)
        {

            //sol
            for (float i = 0f; i < 50f; i++)
            {
                for (float j = 0f; j < 50f; j++)
                { 
                    float PerlinY = Mathf.PerlinNoise(i * 0.05f, j * 0.05f) * 3;
                    Instantiate(cube, new Vector3(j, PerlinY, i), Quaternion.identity);

                }
            }

            //variatobn bloc
           


            //mur en x et Y
            
            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Instantiate(cube, new Vector3(x, y, 0), Quaternion.identity);
                }
            }
            for (int x = 0; x < 50; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Instantiate(cube, new Vector3(x, y, 49), Quaternion.identity);
                }
            }


            //mur en Z et Y
            for (int z = 0; z < 50; z++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Instantiate(cube, new Vector3(0, y, z), Quaternion.identity);
                }
            }
            for (int z = 0; z < 50; z++)
            {
                for (int y = 0; y < 15; y++)
                {
                    Instantiate(cube, new Vector3(49, y, z), Quaternion.identity);
                }
            }
            

        }
        if (bon == 0)
        {

        }

    

    }
}
