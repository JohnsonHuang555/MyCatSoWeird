using UnityEngine;

public class Pet : MonoBehaviour
{
    [SerializeField] float accumHunger;
    [SerializeField] GameObject feedButton;
    SpriteRenderer render;
    int TO_LEVEL_2 = 10;

    private void Start()
    {
        accumHunger = 0;
        render = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {

    }

    public void Feed()
    {
        accumHunger++;
        if (accumHunger == TO_LEVEL_2)
        {
            Vector3 objectScale = transform.localScale;
            transform.localScale = new Vector3(objectScale.x * 2, objectScale.y * 2, objectScale.z * 2);
        }
    }
}
