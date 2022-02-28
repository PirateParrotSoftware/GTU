using UniRx;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public struct SendReportEvent
{
    
}

public class SendReportButton : MonoBehaviour
{
    [Inject] private Button sendReportButton;
    
    private void Start()
    {
        sendReportButton.OnClickAsObservable()
            .Subscribe(x =>
                {
                    MessageBroker.Default.Publish(new SendReportEvent());
                }).AddTo(this);
    }
}
