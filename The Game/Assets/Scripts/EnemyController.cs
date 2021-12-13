using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update

    NavMeshAgent myNavMesgAgent;
    public Transform player;
    public GameObject menu;
    public bool oculto;
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
        else if(PlayerController.key){
            myNavMesgAgent.SetDestination(player.position);
        }

        if(Vector3.Distance(player.position, transform.position) < 1.5)
        {
            menu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
