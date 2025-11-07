using UnityEngine;

public class NaNChecker : MonoBehaviour {
    void Update() {
        foreach (var t in FindObjectsOfType<Transform>()) {
            if (!IsFinite(t.position) || !IsFinite(t.localScale)) {
                Debug.LogError($"NaN or Inf detected in {t.name}");
            }
        }
    }

    bool IsFinite(Vector3 v) {
        return float.IsFinite(v.x) && float.IsFinite(v.y) && float.IsFinite(v.z);
    }
}
