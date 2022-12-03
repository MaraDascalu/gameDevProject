using System.Collections;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int position = 100;
    public bool sectionCreation = false;
    public int sectionNumber;

    void Update()
    {
        if (sectionCreation == false)
        {
            sectionCreation = true;
            StartCoroutine(GenerateSection());
           // StartCoroutine(DeleteSection());
        }
    }

    IEnumerator GenerateSection()
    {
        sectionNumber = Random.Range(0, 2);
        Instantiate(section[sectionNumber], new Vector3(0, 0, position), Quaternion.identity);
        position += 100;
        yield return new WaitForSeconds(2);
        sectionCreation = false;
    }

    /*IEnumerator DeleteSection()
    {
        sectionNumber = Random.Range(0, 2);
        Instantiate(section[sectionNumber], new Vector3(0, 0, position), Quaternion.identity);
        position += 100;
        yield return new WaitForSeconds(2);
        sectionCreation = false;
    }*/
}
