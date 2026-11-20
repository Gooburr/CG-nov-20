using UnityEngine;

public class Bowser : MonoBehaviour
{
    public Material bowserMat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bowserMat.SetFloat("_Toggle", 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            bowserMat.SetFloat("_Toggle", 1.0f);
        }
    }
}
