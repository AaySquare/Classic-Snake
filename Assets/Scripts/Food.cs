using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] private Transform topBorder;
    [SerializeField] private Transform bottomBorder;
    [SerializeField] private Transform leftBorder;
    [SerializeField] private Transform rightBorder;

    //Spawn food at a random position between the borders of the game
    public void SpawnFood()
    {
        int randomX = (int)Random.Range(leftBorder.position.x+2, rightBorder.position.x-2);
        int randomY = (int)Random.Range(topBorder.position.y-2, bottomBorder.position.y+2);
        Vector2 position = new Vector2(randomX, randomY);

        GameObject food = ObjectPool.SharedInstance.GetPooledObject();
        if(food != null)
        {
            food.transform.position = position;
            food.SetActive(true);
        }
    }
}