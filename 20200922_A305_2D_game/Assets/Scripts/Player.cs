using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject congratulation;
    public GameObject failure;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("觸及傳送門");
        congratulation.SetActive(true);

    }

}
