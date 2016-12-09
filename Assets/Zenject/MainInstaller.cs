using UnityEngine;
using Zenject;

public class MainInstaller : MonoInstaller<MainInstaller>
{
	
    public override void InstallBindings()
    {
		Container.Bind<IHogeService> ().To<HogeService> ().AsSingle();
		Container.Bind<IPrefab> ().FromPrefab (Resources.Load<GameObject>("Sample")).AsSingle();
    }
}