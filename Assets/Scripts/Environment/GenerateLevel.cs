using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int position = 100;
    public bool sectionCreation = false;
    public int sectionNumber;
    public List<GameObject> activeSections = new List<GameObject>();
    public GameObject currentSection;
    public bool firstDelete = true;
    public bool sectionDelete = false;

    void Update()
    {
        if (sectionCreation == false)
        {
            sectionCreation = true;
            StartCoroutine(GenerateSection());
        }

        if (sectionDelete == false)
        {
            sectionDelete = true;
            StartCoroutine(DeleteSection());
        }
    }

    IEnumerator GenerateSection()
    {
        sectionNumber = Random.Range(0, 2);
        currentSection = Instantiate(section[sectionNumber], new Vector3(0, 0, position), Quaternion.identity);
        activeSections.Add(currentSection);
        position += 100;
        yield return new WaitForSeconds(8);
        sectionCreation = false;
    }

    IEnumerator DeleteSection()
        {
            if(firstDelete == true)
            {
                yield return new WaitForSeconds(15);
                firstDelete = false;
            }

            yield return new WaitForSeconds(15);
            Destroy(activeSections[0]);
            activeSections.RemoveAt(0);
            sectionDelete = false;
        }
}


