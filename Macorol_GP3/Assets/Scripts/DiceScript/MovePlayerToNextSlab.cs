using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerToNextSlab : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject[] Slabs;
    public static MovePlayerToNextSlab instance;
    private int moveSpeed = 5;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Slabs = GameObject.FindGameObjectsWithTag("Slab");
    }

    public void MovePlayerFromDiceNumber(int Number)
    {
        Debug.Log("Is now Processing");
        for (int i = 0; i < Number; i++)
        {
            if (i < Number)
            {
                StartCoroutine(MovePlayerOneSlabToAnother(Number));
            }
        }
    }

    IEnumerator MovePlayerOneSlabToAnother(int number)
    {
        Vector3 destination = Slabs[number].transform.position;
        while (Vector3.Distance(Player.transform.position, destination) > 0.1f)
        {
            Player.transform.position = Vector3.Lerp(Player.transform.position, destination, moveSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
