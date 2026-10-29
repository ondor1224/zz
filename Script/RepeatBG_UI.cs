using UnityEngine;

public class RepeatBG_UI : MonoBehaviour
{
    [SerializeField][Range(1f, 200f)] float speed = 3f;

    [SerializeField] float posValue;

    Vector2 startPos;

    float newPos;

    void Start()
    {
        startPos = transform.position;
    }
   
    void Update()
    {
        newPos = Mathf.Repeat(Time.time * speed, posValue);
        transform.position = startPos + Vector2.down * newPos;

    }



}
