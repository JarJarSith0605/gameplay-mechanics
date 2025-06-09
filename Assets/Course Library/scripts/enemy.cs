using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody EnemyRb;
    private GameObject Player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnemyRb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (Player.transform.position
        - transform.position).normalized;
        EnemyRb.AddForce(lookDirection * speed);
    }
}
