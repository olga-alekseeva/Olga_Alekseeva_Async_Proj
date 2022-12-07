using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System.Threading.Tasks;

public class FirstLessonSecondTask : MonoBehaviour
{
    [SerializeField] public Button _button;
    private CancellationTokenSource _cancellationTokenSource;
    public void Start()
    {
        _cancellationTokenSource = new CancellationTokenSource();
        _button.onClick.AddListener(StartTasks);

    }
    private void OnDestroy()
    {
        _button.onClick.RemoveAllListeners();
        _cancellationTokenSource.Cancel();
        _cancellationTokenSource.Dispose();
    }
    public void StartTasks()
    {
        Task1Async(_cancellationTokenSource.Token);
        Task2Async(_cancellationTokenSource.Token, 60);
    }
    public async void Task1Async(CancellationToken cancellationToken)
    {
        await Task.Delay(1000, cancellationToken);
        Debug.Log("Программа завершила работу через 1 секунду");

    }
    public async void Task2Async(CancellationToken cancellationToken, int framesCount)
    {
        for (int i = 0; i < framesCount; i++)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                Debug.Log("cancelled by token");
                break;
            }
            await Task.Yield();
        }
        Debug.Log("60 кадров прошло");

    }

}


