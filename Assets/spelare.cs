using UnityEngine;

public class spelare : MonoBehaviour
{
    public GameObject gameManager; 

    [SerializeField] private float playerSpeed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(0, -3.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed *  Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
            
        } 
    }



    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Test: " + other.gameObject.name);
        if (other.gameObject.tag == "Coins")
        {
            gameManager.GetComponent<gamemanager>().coins += 1;
            other.gameObject.transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0);





        }

    }
}
