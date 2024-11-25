using TMPro;
using UnityEngine;

public class PackageDisplay : MonoBehaviour
{
    public void UpdatePackageCount(double packageCount, TextMeshProUGUI textToChange, string optionalEndText = null)
    {
        string[] suffixes = { "", "k", "M", "B", "T", "Q" };

        int index = 0;

        while (packageCount >= 1000 && index <= suffixes.Length - 1)
        {
            packageCount /= 1000;
            index++;

            if (index >= suffixes.Length - 1 && packageCount >= 1000)
            {
                break;
            }
        }

        string formattedText;

        if (index == 0)
        {
            formattedText = packageCount.ToString();
        }

        else
        {
            formattedText = packageCount.ToString("F1") + suffixes[index];
        }

        textToChange.text = formattedText + optionalEndText;
    }
}
