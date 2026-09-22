using UnityEngine;

public class Tourner : MonoBehaviour
{

    private void Awake()
    {
        Debug.Log("Je suis Awake");
    }


    private void OnEnable()
    {
        Debug.Log("I'm Enabled");
    }

    private void Update()
    {
        Debug.Log("je suis dan l'update");
    }


    private void OnDestroy()
    {
        Debug.Log("je suis mort");
    }
}
