using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Player1 : MonoBehaviour
{
    private Rigidbody rb;

    public Text text;

    int count = 0;

    public string targetSceneName;

    public float speed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        Vector3 Position1 = new Vector3(1.5f, 0.15f, 2.4f);
        Vector3 Position2 = new Vector3(2.5f, 0.15f, 2.4f);
        Vector3 Position3 = new Vector3(2.5f, 0.15f, 0.4f);
        Vector3 Position4 = new Vector3(1.5f, 0.15f, 0.4f);
        Vector3 Position5 = new Vector3(-1.5f, 0.15f, 0.4f);
        Vector3 Position6 = new Vector3(-1.5f, 0.15f, 1.4f);
        Vector3 Position7 = new Vector3(-3.5f, 0.15f, 1.4f);
        Vector3 Position8 = new Vector3(2.5f, 0.15f, 1.4f);
        Vector3 Position9 = new Vector3(-1.5f, 0.15f, -3.6f);
        Vector3 Position10 = new Vector3(-2.5f, 0.15f, -3.6f);
        Vector3 Position11 = new Vector3(-2.5f, 0.15f, 1.4f);
        Vector3 Position12 = new Vector3(3.5f, 0.15f, -3.6f);
        Vector3 Position13 = new Vector3(3.5f, 0.15f, -2.6f);
        Vector3 Position14 = new Vector3(1.5f, 0.15f, -2.6f);
        Vector3 Position15 = new Vector3(1.5f, 0.15f, -0.6f);
        Vector3 Position16 = new Vector3(-1.5f, 0.15f, -0.6f);
        Vector3 Position17 = new Vector3(2.5f, 0.15f, -0.6f);
        Vector3 Position18 = new Vector3(1.5f, 0.15f, -4.6f);
        Vector3 Position19 = new Vector3(-0.5f, 0.15f, -4.6f);
        Vector3 Position20 = new Vector3(2.5f, 0.15f, -3.6f);
        Vector3 Position21 = new Vector3(-0.5f, 0.15f, 2.4f);
        Vector3 Position22 = new Vector3(0.5f, 0.15f, 2.4f);

        if (currentPosition == Position1)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Vector3 targetPos = new Vector3(1.5f, 0.15f, 0.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, 2.4f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position2)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(1.5f, 0.15f, 2.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, 0.4f);
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
                Vector3 targetPos = new Vector3(2.5f, 0.15f, 2.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-1.5f, 0.15f, 0.4f);
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
                Vector3 targetPos = new Vector3(1.5f, 0.15f, 2.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-1.5f, 0.15f, 0.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, 0.4f);
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
                Vector3 targetPos = new Vector3(-1.5f, 0.15f, 1.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-1.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, 0.4f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position6)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-3.5f, 0.15f, 1.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-1.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, 1.4f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position7)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, 1.4f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position8)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, 2.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-3.5f, 0.15f, 1.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, 0.4f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position9)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-1.5f, 0.15f, 1.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-2.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(3.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position10)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-2.5f, 0.15f, 1.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(3.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position11)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-3.5f, 0.15f, 1.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, 1.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-2.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position12)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(3.5f, 0.15f, -2.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-2.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position13)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(1.5f, 0.15f, -2.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(3.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position14)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(1.5f, 0.15f, -0.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(1.5f, 0.15f, -4.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(3.5f, 0.15f, -2.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position15)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-1.5f, 0.15f, -0.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(1.5f, 0.15f, -4.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, -0.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position16)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-1.5f, 0.15f, 1.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-1.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, -0.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position17)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-1.5f, 0.15f, -0.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position18)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(1.5f, 0.15f, -0.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-0.5f, 0.15f, -4.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position19)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-0.5f, 0.15f, 2.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(1.5f, 0.15f, -4.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position20)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(2.5f, 0.15f, -0.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-2.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(3.5f, 0.15f, -3.6f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position21)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-5.5f, 0.15f, 2.4f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-0.5f, 0.15f, -4.6f);
                TeleportTo(targetPos);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(0.5f, 0.15f, 2.4f);
                TeleportTo(targetPos);
            }
        }
        if (currentPosition == Position22)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                count++;
                text.text = $"{count}";
                Debug.Log(count);
                Vector3 targetPos = new Vector3(-5.5f, 0.15f, 2.4f);
                TeleportTo(targetPos);
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (count == 17)
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }
}