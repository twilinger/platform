using UnityEngine;
using static Health;
public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private CameraController cam;

    private void Awake()
    {
        cam = Camera.main.GetComponent<CameraController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (collision.transform.position.x < transform.position.x)
            {
                cam.MoveToNewRoom(nextRoom);
                //nextRoom.GetComponent<Room>().ActivateRoom(true);
                //previousRoom.GetComponent<Room>().ActivateRoom(false);
            }
            else
            {
                cam.MoveToNewRoom(previousRoom);
                //previousRoom.GetComponent<Room>().ActivateRoom(true);
                //nextRoom.GetComponent<Room>().ActivateRoom(false);
                
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            if (collision.transform.position.x < transform.position.x)
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<Health>().TakeDamage(999);
                gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                //nextRoom.GetComponent<Room>().ActivateRoom(false);
            }
        }
    }
}