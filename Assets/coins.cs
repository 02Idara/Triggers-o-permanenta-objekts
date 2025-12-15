using UnityEngine;

public class coins : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D Other)
    {
        if (Other.gameObject.tag == "wall" || Other.gameObject.tag == "ncp")
        {
            transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0);
            Debug.Log("telo");
            
        }
        
    }
}
