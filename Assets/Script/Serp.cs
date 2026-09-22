using Unity.VisualScripting;
using UnityEngine;

public class Serp : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject favorite;
    public GameObject init;
    private GameObject choix;

    void Start()
    {
        for (int i = 0; i < 10000; i++)
        {
            alea();
            GameObject nouveau = GameObject.Instantiate(init, Vector3.Lerp(favorite.transform.position, choix.transform.position, 0.5f), Quaternion.identity);
            favorite = nouveau;
        }
    }

    void alea()
    {
        int alea = Random.Range(0, 3);
        if (alea == 0)
        {
            if (choix == a)
            {
                int alea2 = Random.Range(0, 2);
                if (alea2 == 0)
                {
                    choix = b;
                }
                else
                {
                    choix = c;
                }
            }
            else
            {
                choix = a;
            }
        }
        if (alea == 1)
        {
            if (choix == b)
            {
                int alea2 = Random.Range(0, 2);
                if (alea2 == 0)
                {
                    choix = c;
                }
                else
                {
                    choix = a;
                }
            }
            else
            {
                choix = b;
            }
            
        }
        else
        {
            if (choix == c)
            {
                int alea2 = Random.Range(0, 2);
                if (alea2 == 0)
                {
                    choix = a;
                }
                else
                {
                    choix = b;
                }
            }
            else
            {
                choix = c;
            }
            
        }
        return ;
    }

    void Update()
    {
        
    }
}
