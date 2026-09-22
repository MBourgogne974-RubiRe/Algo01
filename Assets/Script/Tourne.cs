using UnityEngine;

public class Tourne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Debug.Log("awake");
    }
    private void OnEnable()
    {
        Debug.Log("Enabled");
    }
    private void Update()
    {
        Debug.Log("update en cours");
    }
    private void OnDestroy()
    {
        Debug.Log("Man I'm dead");
    }
}