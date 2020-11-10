using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject congratulation;
    public GameObject failure;
    public Text textCount;
    public int count;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("觸及傳送門");
        congratulation.SetActive(true);


    if(collision.tag == "cherry")
        {
            Destroy(collision.gameObject);
            count++;
            textCount.text = "Coin:" + count;
        }
    }
}
