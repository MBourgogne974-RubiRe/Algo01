using UnityEngine;

public class Exercice2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int age;
    void Start()
    {
        age = 10;
        if (age >= 18)
        {
            Debug.Log("Welcome to Jumanji");
        }
        else
        {
            Debug.Log("Good Afternoon, good evening and good night");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
