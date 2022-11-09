using System.Collections;
using UnityEngine;

public class SpawnCubs : MonoBehaviour
{
    public GameObject cube;
    public int minCubes = 1, maxCubes = 5;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject spawnCube = null;
            Vector3 pos = transform.position;
            int howMenyCubs = Random.Range(minCubes, maxCubes);
            for (int i = 0; i < howMenyCubs; i++)
            {
                if(i > 0)
                {
                    pos = new Vector3(spawnCube.transform.position.x, spawnCube.transform.position.y, spawnCube.transform.position.z + 0.9f);
                }
                spawnCube = Instantiate(cube, pos, Quaternion.identity) as GameObject;
            }
            float wait = 4.2f;
            switch (howMenyCubs)
            {
                case 1: wait = 2f; break;
                case 2: wait = 2.8f; break;
                case 3: wait = 3.3f; break;
                case 4: wait = 3.7f; break;                
            }
            yield return new WaitForSeconds(wait);
        }             
    }
}
