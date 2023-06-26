using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMain : MonoBehaviour
{
    [SerializeField]
    private float delaybeforeloading = 3f;
    [SerializeField]
    private string Next;

    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;

        if(timeElapsed > delaybeforeloading)
        {
            SceneManager.LoadScene(Next);
        }
    }

}
