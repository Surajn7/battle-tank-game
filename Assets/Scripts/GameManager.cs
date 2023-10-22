using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject gameOver;
    public List<GameObject> rootGameObjects;

    private void Awake()
    {
        this.gameObject.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
       /* List<GameObject> allGameObjects = new List<GameObject>();
       foreach (GameObject go in rootGameObjects)
           Debug.Log(go.name);*/
    }

    // Update is called once per frame
    void Update()
    {
        CheckObjects();
    }

    private IEnumerator DestroyObjects(float time)
    {
        yield return new WaitForSeconds(time);
    }

    public void CheckObjects()
    {
        if(gameObject.GetComponent<EnemyScript>() == null)
        {
            for(int i=0;i<rootGameObjects.Count;i++)
            {
                StartCoroutine(DestroyObjects(0.5f));
                rootGameObjects.RemoveAt(i);
                Destroy(rootGameObjects[i]);                        
            }
        }
        if (rootGameObjects.Count == 0)
        {
            Destroy(enemy.gameObject);
            gameOver.SetActive(true); }
        else
        {
            Debug.Log("Length is more than 0 ");
        }
    }
}
