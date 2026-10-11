using UnityEngine;

public class Fruit : MonoBehaviour
{
    public GameObject fruitSlicedPrefab;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Blade")
        {
            Instantiate(fruitSlicedPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}