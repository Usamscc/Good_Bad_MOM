using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    
    public static ScoreManager instance;
    
    [SerializeField] private int beautyFactor;
    [SerializeField] private int beautyScore = 100;
    [SerializeField] private PlayerData playerData;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }
    
}
