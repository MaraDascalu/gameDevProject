using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] sectionCity;
    public GameObject[] sectionForest;
    public int position = 100;
    public bool sectionCreation = false;
    public int sectionNumber;
    public List<GameObject> activeSectionsCity = new List<GameObject>();
    public List<GameObject> activeSectionsForest = new List<GameObject>();
    public GameObject currentSection;
    public bool firstDelete = true;
    public bool sectionDelete = false;

    void Update()
    {
        if (sectionCreation == false)
        {
            sectionCreation = true;

            if (PlayerMovement.map == 1)
            {
                StartCoroutine(GenerateSectionCity());
            }
            else if (PlayerMovement.map == 2)
            {
                StartCoroutine(GenerateSectionForest());
            }
        }

        if (sectionDelete == false)
        {
            sectionDelete = true;

            if (PlayerMovement.map == 1)
            {
                StartCoroutine(DeleteSectionCity());
            }
            else if (PlayerMovement.map == 2)
            {
                StartCoroutine(DeleteSectionForest());
            }
        }
    }

    IEnumerator GenerateSectionCity()
    {
        sectionNumber = Random.Range(0, 2);
        currentSection = Instantiate(sectionCity[sectionNumber], new Vector3(0, 0, position), Quaternion.identity);
        activeSectionsCity.Add(currentSection);
        position += 100;
        yield return new WaitForSeconds(3);
        sectionCreation = false;
    }

    IEnumerator DeleteSectionCity()
    {
        if(firstDelete == true)
        {
            yield return new WaitForSeconds(30);
            firstDelete = false;
        }

        yield return new WaitForSeconds(20);
        Destroy(activeSectionsCity[0]);
        activeSectionsCity.RemoveAt(0);
        sectionDelete = false;
    }

    IEnumerator GenerateSectionForest()
    {
        sectionNumber = Random.Range(0, 4);
        currentSection = Instantiate(sectionForest[sectionNumber], new Vector3(-600.45f, 109.35f, position - 411), Quaternion.Euler(new Vector3(0, -90, 0)));
        activeSectionsForest.Add(currentSection);
        position += 100;
        yield return new WaitForSeconds(3);
        sectionCreation = false;
    }

    IEnumerator DeleteSectionForest()
    {
        if (firstDelete == true)
        {
            yield return new WaitForSeconds(30);
            firstDelete = false;
        }

        yield return new WaitForSeconds(50);
        Destroy(activeSectionsForest[0]);
        activeSectionsForest.RemoveAt(0);
        sectionDelete = false;
    }
}


