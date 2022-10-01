using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;

    public float gravity = -9.8f;
    public float strength = 5f;

    private void Update()
    {
        // TODO: May not want to have this and just do it based off touch ended.
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            // TODO: Just finished touching screen
            // if (touch.phase == TouchPhase.Ended)
            // just touched the screen
            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }

        // TODO: This could probably be moved to fixedUpdate
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
}
