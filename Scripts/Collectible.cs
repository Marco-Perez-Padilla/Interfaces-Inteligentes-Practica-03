using UnityEngine;

public class Collectible : MonoBehaviour {
  void OnTriggerEnter(Collider other) {
    if (other.CompareTag("Player")) {
      Debug.Log("Collected by: " + other.name);
      Destroy(gameObject);
    }
  }
}