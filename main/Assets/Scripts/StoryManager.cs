using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class StoryManager : MonoBehaviour
{


    public BookScript book;
    public TextMeshProUGUI pageTitel;
    public TextMeshProUGUI pageTextContent;
    public TextMeshProUGUI pageNumber;

    public int pageIndex;




    private void OnValidate()
    {
        
    }
 

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (book.page.Count-1 > pageIndex)
            {
                pageIndex++;
            }
            else
            {
                Debug.Log("No more pages");
            }
                

        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (pageIndex != 0)
            {
                pageIndex--;
            }
            else
            {
                Debug.Log("No more pages");
            }
           
        }


        if (book.page.Count > pageIndex )
        {
            pageTitel.text = book.page[pageIndex].pageTitel.ToString();
            pageTextContent.text = book.page[pageIndex].pageText.ToString();
            pageNumber.text = pageIndex.ToString();
        }
      
    }
}
