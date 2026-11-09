using UnityEngine;

// Reimplementa o codigo de PigMove

public class ZombieMove : MonoBehaviour {

    public GameObject goal;
    Vector3 direction;
    public float speed;

    private void LateUpdate() {
        direction = goal.transform.position - this.transform.position;
        this.transform.LookAt(goal.transform.position);

        if(direction.magnitude > 1){
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            this.transform.position = this.transform.position + velocity;
        }
    }
}
