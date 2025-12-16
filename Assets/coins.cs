using UnityEngine;
using UnityEngine.UIElements;

public class coins : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private bool IsValidPos(Collider2D coin)
    {
        GameObject[] walls;
        walls = GameObject.FindGameObjectsWithTag("wall");
        foreach (var wall in walls)
        {
            Debug.Log(wall);
            var wall_collider = wall.GetComponent<BoxCollider2D>();
            if (coin.bounds.Intersects(wall_collider.bounds))
            {
                Debug.Log("wall spawn!");
                return false;
            }
        }
        Debug.Log("no wall spawn!");
        return true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsValidPos(GetComponent<Collider2D>()))
        {
            transform.position = new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0);
        }
    }

}
