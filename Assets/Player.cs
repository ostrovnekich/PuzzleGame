using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Player : MonoBehaviour
{
    private Rigidbody rb;

    public Text text;

    Vector3 targetPosition = new Vector3(-2.491f, 0.1397809f, -1.424f);

    int count = 0;

    public string targetSceneName;

    public float speed = 5f;

    private BoxCollider boxCollider;

    public int check = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
    }

    void TeleportTo(Vector3 newPosition)
    {
        StartCoroutine(MoveSmoothly(newPosition));
    }

    IEnumerator MoveSmoothly(Vector3 targetPosition)
    {
        float journeyLength = Vector3.Distance(transform.position, targetPosition);
        float startTime = Time.time;

        while (transform.position != targetPosition)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distCovered / journeyLength;

            transform.position = Vector3.Lerp(transform.position, targetPosition, fractionOfJourney);

            yield return null;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 rotate = transform.eulerAngles;
            rotate.y = 0;
            transform.rotation = Quaternion.Euler(rotate);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 rotate = transform.eulerAngles;
            rotate.y = -90;
            transform.rotation = Quaternion.Euler(rotate);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 rotate = transform.eulerAngles;
            rotate.y = 180;
            transform.rotation = Quaternion.Euler(rotate);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 rotate = transform.eulerAngles;
            rotate.y = 90;
            transform.rotation = Quaternion.Euler(rotate);
        }

        Vector3 currentPosition = transform.position;
        Vector3 Position1 = new Vector3(-2.491f, 0.1397809f, -1.424f);
        Vector3 Position2 = new Vector3(-2.4f, 0.1397809f, 1.4f);
        Vector3 Position3 = new Vector3(3.5f, 0.1397809f, -1.4f);
        Vector3 Position4 = new Vector3(3.5f, 0.1397809f, -2.57f);
        Vector3 Position5 = new Vector3(-1.5f, 0.1397809f, -2.5f);
        Vector3 Position6 = new Vector3(-1.5f, 0.1397809f, -3.5f);
        Vector3 Position7 = new Vector3(3.5f, 0.1397809f, 1.5f);
        Vector3 Position8 = new Vector3(-1.5f, 0.1397809f, 1.5f);
        if (count < 7)
        {
            if (currentPosition == Position1)
            {
                if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.UpArrow) && check == 1))
                {
                    count++;
                    text.text = $"{count}";
                    Vector3 targetPos = new Vector3(-2.4f, 0.1397809f, 1.4f);
                    TeleportTo(targetPos);
                    targetPosition = new Vector3(-2.4f, 0.1397809f, 1.4f);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(3.5f, 0.1397809f, -1.4f);
                    TeleportTo(targetPos);
                }
            }
            if (currentPosition == Position2)
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(3.5f, 0.1397809f, 1.5f);
                    TeleportTo(targetPos);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(-2.491f, 0.1397809f, -1.424f);
                    TeleportTo(targetPos);
                }
            }
            if (currentPosition == Position3)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(3.5f, 0.1397809f, 1.5f);
                    TeleportTo(targetPos);
                }
                if (Input.GetKeyDown(KeyCode.A))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(-2.491f, 0.1397809f, -1.424f);
                    TeleportTo(targetPos);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(3.5f, 0.1397809f, -2.57f);
                    TeleportTo(targetPos);
                }
            }
            if (currentPosition == Position4)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(3.5f, 0.1397809f, 1.5f);
                    TeleportTo(targetPos);
                }
                if (Input.GetKeyDown(KeyCode.A))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(-1.5f, 0.1397809f, -2.5f);
                    TeleportTo(targetPos);
                }
            }
            if (currentPosition == Position5)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(-1.5f, 0.1397809f, 1.5f);
                    TeleportTo(targetPos);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(-1.5f, 0.1397809f, -3.5f);
                    TeleportTo(targetPos);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(3.5f, 0.1397809f, -2.57f);
                    TeleportTo(targetPos);
                }
            }
            if (currentPosition == Position6)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(-1.5f, 0.1397809f, 1.5f);
                    TeleportTo(targetPos);

                }
                if (Input.GetKeyDown(KeyCode.A))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(-2.5f, 0.1397809f, -3.5f);
                    TeleportTo(targetPos);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(2.5f, 0.1397809f, -3.5f);
                    TeleportTo(targetPos);
                    rb.useGravity = true;
                }
            }
            if (currentPosition == Position7)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(-2.4f, 0.1397809f, 1.4f);
                    TeleportTo(targetPos);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(3.5f, 0.1397809f, -2.57f);
                    TeleportTo(targetPos);
                }
            }
            if (currentPosition == Position8)
            {
                if (Input.GetKeyDown(KeyCode.A))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(-2.4f, 0.1397809f, 1.4f);
                    TeleportTo(targetPos);
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(-1.5f, 0.1397809f, -3.5f);
                    TeleportTo(targetPos);
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    count++;
                    text.text = $"{count}";
                    Debug.Log(count);
                    Vector3 targetPos = new Vector3(3.5f, 0.1397809f, 1.5f);
                    TeleportTo(targetPos);
                }
            }
        }
        else 
        {
            SceneManager.LoadScene(targetSceneName);
        }


        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
