using UnityEngine;
using TMPro;

public class PotionScoring : MonoBehaviour
{
    public GameObject splashEffectPrefab;
    public GameObject scorePopupPrefab;
    
    private GameObject scorePopupInstance;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Throwable"))
        {
            // getting the position where the potion was grabbed
            ThrowableData data = collision.gameObject.GetComponent<ThrowableData>();
            Vector3 throwOrigin = data != null ? data.releasePoint : collision.gameObject.transform.position;
            Vector3 impactPoint = collision.contacts[0].point;

            //calculating the score
            float score = Vector3.Distance(throwOrigin, impactPoint);

            //showing splash effect upon collision
            Instantiate(splashEffectPrefab, impactPoint, Quaternion.identity);

            //update the score
            Vector3 scorePosition = new Vector3(2.970037f, 4.76f, 6.32f);
            if (scorePopupInstance == null)
            {
                scorePopupInstance = Instantiate(scorePopupPrefab, scorePosition, Quaternion.identity);
            }
            else
            {
                scorePopupInstance.transform.position = scorePosition;
            }

            TextMeshProUGUI text = scorePopupInstance.GetComponentInChildren<TextMeshProUGUI>();
            if (text != null)
            {
                text.text = "Score: " + score.ToString("F2");
            }
        }
    }
}
