using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{
    [SerializeField] private Text dayCountText;
    private List<PointController> currentPlaces = new();
    [SerializeField] PointController placesPrefab;
    [SerializeField] Button enterButton;
    [SerializeField] Text nameText;
    [SerializeField] Text levelText;
    private PointController currentlySelectedPoint;
    [SerializeField] private AudioSource audioSource;

    void Start()
    {
        SetSoundsToAllButtons();
        GeneratePlaces();
    }


    public void SelectPoint(PointController point)
    {

        if (currentlySelectedPoint == point)
        {
            return;
        }

        currentlySelectedPoint = point;
        UpdateText();
    }

    public void WaitButtonOnClick()
    {
        GameManager.dayCount++;
        GeneratePlaces();
        UpdateText();
    }

    private void SetSoundsToAllButtons()
    {
        Button[] buttons = FindObjectsOfType<Button>();
        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => GameManager.PlayButtonSound(audioSource));
        }

    }

    private void UpdateText()
    {
        if (currentlySelectedPoint != null)
        {
            nameText.text = currentlySelectedPoint.nameField;
            levelText.text = currentlySelectedPoint.levelField;
            enterButton.interactable = true;
            GameManager.levelName = nameText.text;
        }
        else
        {
            nameText.text = "";
            levelText.text = "";
            enterButton.interactable = false;
            GameManager.levelName = "";
        }

        dayCountText.text = GameManager.dayCount.ToString();
    }


    private void GeneratePlaces()
    {
        ClearOldPlaces();
        int count = Random.Range(3, 6);

        for (int i = 0; i < count; i++)
        {
            float width = Random.Range(-4, 5) * 100f;

            float height = Random.Range(-3, 4) * 50f;

            Vector3 randomPosition = new Vector3(width, height, 0);
            GameObject pointGO = Instantiate(placesPrefab.gameObject, gameObject.transform, false);

            RectTransform rectTransform = pointGO.GetComponent<RectTransform>();
            rectTransform.anchoredPosition = randomPosition;

            PointController pointController = pointGO.GetComponent<PointController>();
            if (pointController != null)
            {
                currentPlaces.Add(pointController);
                pointController.Initialize(this, Random.Range(1, GameManager.dayCount).ToString(),
                    Names.GetRandomName());
                pointGO.GetComponent<Button>().onClick.AddListener(() => GameManager.PlayButtonSound(audioSource));
            }

        }

        SelectPoint(null);
        UpdateText();
    }

    private void ClearOldPlaces()
    {

        foreach (PointController point in currentPlaces)
        {
            if (point != null)
            {
                Destroy(point.gameObject);
            }
        }

        currentPlaces.Clear();

    }
}
