using UnityEngine;

public class TriggerColour : MonoBehaviour {
  private Color originalColor;

  private int damage = 0;

  private void OnTriggerEnter(Collider other) {
    Renderer rend = other.GetComponent<Renderer>();
    if (rend != null) {
      originalColor = rend.material.color;
      rend.material.color = Color.green;
    }

    damage += 10;
    Debug.Log("current damage: " + damage);
  }

  private void OnTriggerExit(Collider other) {
    Renderer rend = other.GetComponent<Renderer>();
    if (rend != null) {
      rend.material.color = originalColor;
    }
  }
}
