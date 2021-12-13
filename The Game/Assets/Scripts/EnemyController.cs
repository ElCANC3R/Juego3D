using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update

    NavMeshAgent myNavMesgAgent;
    public Transform player;
    public GameObject menu;
    public bool oculto;
    private int vida = 5;
    void Start()
    {
        myNavMesgAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
     
        if(Vector3.Distance(player.position, transform.position) <8 && !oculto)
        {
            myNavMesgAgent.SetDestination(player.position);
        }
        else if(PlayerController.items >= 10){
            myNavMesgAgent.SetDestination(player.position);
        }

        if(Vector3.Distance(player.position, transform.position) < 1.5)
        {
            menu.SetActive(true);
            Time.timeScale = 0;
        }

        if(vida<=0){
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.collider.CompareTag("Bala")){
            vida--;
            Debug.Log(vida);
        }
    }
}
