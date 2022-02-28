using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class ReporterInstaller : MonoInstaller
{
    [SerializeField] private RawImage mapImage;
    [SerializeField] private Camera mapCamera;
    [SerializeField] private OnlineMapsRawImageTouchForwarder touchForwarder;
    
    public override void InstallBindings()
    {
        Container.Bind<Button>().FromComponentSibling().WhenInjectedInto<SendReportButton>();
        Container.BindInterfacesAndSelfTo<MapTextureCreator>().AsSingle().NonLazy();
        Container.Bind<RawImage>().FromInstance(mapImage).WhenInjectedInto<MapTextureCreator>();
        Container.Bind<Camera>().FromInstance(mapCamera).WhenInjectedInto<MapTextureCreator>();
        Container.Bind<OnlineMapsRawImageTouchForwarder>().FromInstance(touchForwarder).AsSingle().NonLazy();
        Container.BindInterfacesAndSelfTo<Reporter>().AsSingle().NonLazy();
        Container.BindInterfacesAndSelfTo<ReportQueue>().AsSingle().NonLazy();
    }
}